

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int opcao = 99;

            do
            {
                Console.Clear();
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("| Menu de conversão de bases:                 |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("| 1. Decimal -> Binário                       |");
                Console.WriteLine("| 2. Binário -> Decimal                       |");
                Console.WriteLine("| 3. Decimal -> Octal                         |");
                Console.WriteLine("| 4. Octal -> Decimal                         |");
                Console.WriteLine("| 5. Decimal -> Hexadecimal                   |");
                Console.WriteLine("| 6. Hexadecimal -> Decimal                   |");
                Console.WriteLine("| 7. Binário -> Octal                         |");
                Console.WriteLine("| 8. Octal -> Binário                         |");
                Console.WriteLine("| 9. Binário -> Hexadecimal                   |");
                Console.WriteLine("| 10. Hexadecimal -> Binário                  |");
                Console.WriteLine("| 11. Octal -> Hexadecimal                    |");
                Console.WriteLine("| 12. Hexadecimal -> Octal                    |");
                Console.WriteLine("|---------------------------------------------|");
                Console.WriteLine("| 0. Sair                                     |");
                Console.WriteLine("|---------------------------------------------|");
                Console.Write("|opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("|---------------------------------------------|");

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Informe um número decimal para ser convertido para binário: ");
                        if (long.TryParse(Console.ReadLine(), out long num) && num >= 0)
                        {
                            Console.WriteLine($"Resultado: {DecimalParaBinario(num)}");
                        }

                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Digite um número binário para ser convertido em decimal: ");

                        if (long.TryParse(Console.ReadLine(), out long nume))
                        {
                            Console.WriteLine($"Resultado: {BinarioParaDecimal(nume)}");
                        }


                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Digite um número Decimal para ser convertido em octal: ");
                        if (long.TryParse(Console.ReadLine(), out num) && num >= 0)
                        {
                            Console.WriteLine($"Resultado: {DecimalParaOctal(num)}");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Digite um número octal para ser convertido em decimal: ");
                        if (long.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"Resultado: {OctalParaDecimal(num)}");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Digite um número Decimal para ser convertido para Hexadecimal: ");
                        if (long.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"Resultado: {DecimalParaHexadecimal(num)}");
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;

                    case 6:
                        string input = "";
                        Console.WriteLine("Digite um número hexadecimal para ser convertido em decimal: ");
                        input = Console.ReadLine();
                        Console.WriteLine($"Resultado: {HexadecimalParaDecimal(input)}");
                        break;

                    case 7:
                        Console.WriteLine("Digite um número binário para ser convertido em octal: ");
                        num = long.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {BinarioParaOctal(num)}");
                        break;

                    case 8:
                        Console.WriteLine("Digite um número octal para ser convertido em binario: ");
                        num = long.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {OctalParaBinario(num)}");
                        break;

                    case 9:
                        Console.WriteLine("Digite um número binário para ser convertido em decimal: ");
                        if (long.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"Resultado: {BinarioParaHexadecimal(num)}");

                        }
                        else
                        {
                            Console.WriteLine("Valor inválido!");
                        }
                        break;

                    case 10:
                        Console.WriteLine("Digite um número hexadecimal para ser convertido em binário: ");
                        input = Console.ReadLine();
                        Console.WriteLine($"Resultado: {HexadecimalParaBinario(input)}");
                        break;
                    case 11:
                        Console.WriteLine("Digite um número octal para ser convertido em hexadecimal: ");
                        if (long.TryParse(Console.ReadLine(), out num))
                            Console.WriteLine($"Resultado: {OctalParaHexadecimal(num)}");
                        break;
                    case 12:
                        Console.WriteLine("Digite um número hexadecimal para ser convertido em octal: ");
                        input = Console.ReadLine();
                        Console.WriteLine($"Resultado: {HexadecimalParaOctal(input)}");
                        break;
                    default:
                        break;
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            } while (opcao != 0);
        }

        static long DecimalParaBinario(long num)
        {
            if (num == 0) return 0;

            int cont = -1;
            long[] valorFinal = new long[1000000];

            long resto = 0;
            long quociente = 0;

            for (int i = 0; num > 0; i++)
            {
                quociente = DivisaoPorDois(num);
                resto = RestoPorDois(num);
                Console.WriteLine($"Passo {i + 1}: {num} / 2 -> Quociente: {quociente}, Resto: {resto}");
                num = quociente;

                valorFinal[i] = resto;
                cont++;

                if (num == 0)
                {
                    Console.WriteLine($"Passo{i + 2}: Junte os valores dos restos dos passos anteriores");

                }
            }

            string resultado = "";

            for (int i = cont; i >= 0; i--)
            {
                resultado += Convert.ToString(valorFinal[i]);
            }

            return long.Parse(resultado);

        }

        static long BinarioParaDecimal(long num)
        {

            string temp = Convert.ToString(num);

            for (int i = 0; i < temp.Length; i++)
            {
                if (Convert.ToInt32(temp[i]) != 48 && Convert.ToInt32(temp[i]) != 49)
                {
                    Console.WriteLine("Valor inválido! Por favor escreva apenas 0 e 1!");
                    return -1;
                }
            }

            long resultadoDecimal = 0;
            int pesoBase = 1;
            int passo = 1;

            Console.WriteLine($"O número em binário é: {temp}");

            for (int j = temp.Length - 1; j >= 0; j--)
            {
                int digitoBinario = temp[j] - '0';

                long termoMultiplicado = digitoBinario * pesoBase;
                resultadoDecimal += termoMultiplicado;
                Console.WriteLine($"Passo {passo}: ({digitoBinario} * 2^{passo - 1}) = {termoMultiplicado}");

                pesoBase *= 2;
                passo++;
            }

            return resultadoDecimal;
        }

        static long DecimalParaOctal(long num)
        {
            if (num == 0) return 0;

            long[] resultadoOctal = new long[10000];
            int cont = -1;

            long quociente = 0;
            long resto = 0;

            string mostrarPassos = "";
            for (int i = 0; num > 0; i++)
            {
                quociente = num / 8;
                resto = num % 8;

                Console.WriteLine($"Passo {i + 1}: {num} / 8 -> Quociente: {quociente}, Resto: {resto}");
                num = quociente;

                resultadoOctal[i] = resto;
                cont++;

                mostrarPassos = mostrarPassos + (i + 1);
                if (num == 0)
                {
                    Console.WriteLine($"Passo {i + 2}: Junte os valores dos restos dos passos: {mostrarPassos}");
                }

            }

            string resultado = "";

            for (int a = cont; a >= 0; a--)
            {
                resultado += Convert.ToString(resultadoOctal[a]);
            }

            return long.Parse(resultado);
        }

        static long OctalParaDecimal(long num)
        {

            string temp = Convert.ToString(num);

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < '0' || temp[i] > '7')
                {
                    Console.WriteLine("Valor inválido! Por favor escreva apenas valores entre 0 e 7!");
                    return -1;
                }
            }

            long resultadoDecimal = 0;
            int pesoBase = 1;
            int passo = 1;

            Console.WriteLine($"O número em octal é: {temp}");

            for (int j = temp.Length - 1; j >= 0; j--)
            {
                int digitoOctal = temp[j] - '0';

                long termoMultiplicado = digitoOctal * pesoBase;
                resultadoDecimal += termoMultiplicado;
                Console.WriteLine($"Passo {passo}: ({digitoOctal} * 8^{passo - 1}) = {termoMultiplicado}");

                if (j == 0)
                {
                    Console.WriteLine($"Passo {j + 2}: Junte todos os valores dos passos anteriores.");
                }

                pesoBase *= 8;
                passo++;
            }

            Console.Write($"Resultado: ");

            return resultadoDecimal;

        }


        static string DecimalParaHexadecimal(long num)
        {
            if (num == 0) return "0";

            int cont = -1;
            char[] valorHexadecimal = new char[1000000];

            long resto = 0;
            long quociente = 0;

            for (int i = 0; num > 0; i++)
            {
                quociente = num / 16;
                resto = num % 16;
                Console.WriteLine($"Passo {i + 1}: {num} / 16 -> Quociente: {quociente}, Resto: {resto}");
                num = quociente;

                if (resto == 10)
                {
                    valorHexadecimal[i] = 'A';
                }
                else if (resto == 11)
                {
                    valorHexadecimal[i] = 'B';
                }
                else if (resto == 12)
                {
                    valorHexadecimal[i] = 'C';
                }
                else if (resto == 13)
                {
                    valorHexadecimal[i] = 'D';
                }
                else if (resto == 14)
                {
                    valorHexadecimal[i] = 'E';
                }
                else if (resto == 15)
                {
                    valorHexadecimal[i] = 'F';
                }
                else
                {
                    valorHexadecimal[i] = Convert.ToChar(resto + 48);

                }

                cont++;

                if (num == 0)
                {
                    Console.WriteLine($"Passo{i + 2}: Junte os valores dos restos dos passos anteriores");
                }

            }

            string resultado = "";

            for (int i = cont; i >= 0; i--)
            {
                resultado += Convert.ToChar(valorHexadecimal[i]);
            }


            Console.Write($"Resultado: ");

            return resultado;
        }

        static long HexadecimalParaDecimal(string num)
        {
            string temp = num.ToUpper();

            for (int i = 0; i < temp.Length; i++)
            {
                if (!((temp[i] >= '0' && temp[i] <= '9') || (temp[i] >= 'A' && temp[i] <= 'F')))
                {
                    Console.WriteLine("Valor inválido! Por favor escreva apenas valores entre 0 e 9 e letras entre A e F!");
                    return -1;
                }
            }

            long resultadoDecimal = 0;
            int pesoBase = 1;
            int passo = 1;

            Console.WriteLine($"O número em hecadecimal é: {temp}");

            for (int j = temp.Length - 1; j >= 0; j--)
            {
                int digitoHexaDecimal = 0;

                if (temp[j] >= '0' && temp[j] <= '9')
                {
                    digitoHexaDecimal = temp[j] - '0';
                }
                else if (temp[j] >= 'A' && temp[j] <= 'F')
                {
                    digitoHexaDecimal = temp[j] - 'A' + 10;
                }

                long termoMultiplicado = digitoHexaDecimal * pesoBase;
                resultadoDecimal += termoMultiplicado;

                Console.WriteLine($"Passo {passo}: ({digitoHexaDecimal} * 16^{passo - 1}) = {termoMultiplicado}");

                pesoBase *= 16;
                passo++;
            }

            return resultadoDecimal;
        }

        static long BinarioParaOctal(long num)
        {

            string temp = Convert.ToString(num);


            for (int i = 0; i < temp.Length; i++)
            {
                if (Convert.ToInt32(temp[i]) != 48 && Convert.ToInt32(temp[i]) != 49)
                {
                    Console.WriteLine("Valor inválido! Por favor escreva apenas 0 e 1!");
                    return -1;
                }
            }

            long binarioDecimal = BinarioParaDecimal(long.Parse(temp));
            long decimalOctal = DecimalParaOctal(binarioDecimal);

            return decimalOctal;
        }

        static long OctalParaBinario(long num)
        {

            string temp = Convert.ToString(num);

            for (int i = 0; i < temp.Length; i++)
            {
                if (temp[i] < '0' || temp[i] > '7')
                {
                    Console.WriteLine("Valor inválido! Por favor escreva apenas valores entre 0 e 7!");
                    return -1;
                }
            }

            long octalParaDecimal = OctalParaDecimal(num);
            Console.WriteLine($"Passo 1: Converter o octal para decimal: {octalParaDecimal}");
            long resultFinal = DecimalParaBinario(octalParaDecimal);
            Console.WriteLine($"Passo 2: Converter o resultado para binário: {resultFinal}");

            return resultFinal;


        }
        static string BinarioParaHexadecimal(long num)
        {

            string temp = Convert.ToString(num);

            for (int i = 0; i < temp.Length; i++)
            {
                if (Convert.ToInt32(temp[i]) != 48 && Convert.ToInt32(temp[i]) != 49)
                {
                    Console.WriteLine("Valor inválido! Por favor escreva apenas 0 e 1!");
                    break;
                }
            }

            long binarioParaDecimal = BinarioParaDecimal(num);
            Console.WriteLine($"Passo 1: Converter o binário para decimal: {binarioParaDecimal}");
            Console.WriteLine();
            string resultado = DecimalParaHexadecimal(binarioParaDecimal);
            Console.WriteLine($"Passo 2: Converter o decimal para hexadecimal: {resultado}");

            return resultado;
        }

        static long HexadecimalParaBinario(string num)
        {
            
            string temp = num.ToUpper();

            long HexaParaDeci = HexadecimalParaDecimal(temp);
            Console.WriteLine($"Passo 1: Converter o valor em hexadecimal para decimal: {HexaParaDeci}");

            long resultado = DecimalParaBinario(HexaParaDeci);
            Console.WriteLine($"Passo 2: Converter o decimal para binário: {resultado}");

            Console.Write($"Resultado final: ");

            return resultado;
        }

        static string OctalParaHexadecimal(long num)
        {


            long octalParaDecimal = OctalParaDecimal(num);
            Console.WriteLine($"Passo 1: Converter o número em octal para decimal: {octalParaDecimal}");
            string decimalParaHexadecimal = DecimalParaHexadecimal(octalParaDecimal);
            Console.WriteLine($"Passo 2: Converter o número em decimal para Hexadecimal: {decimalParaHexadecimal}");

            return decimalParaHexadecimal;
        }

        static long HexadecimalParaOctal(string num)
        {
            

            long hexaParaBinario = HexadecimalParaBinario(num);
            Console.WriteLine($"Passo 1: Converter o número em hexadecimal para binário: {hexaParaBinario}");
            long binarioParaOctal = BinarioParaOctal(hexaParaBinario);
            Console.WriteLine($"Passo 2: Converter o número em binário para octal: {binarioParaOctal}");

            return binarioParaOctal;
        }

        static long DivisaoPorDois(long value)
        {
            return value /= 2;
        }
        static long RestoPorDois(long value)
        {
            return value % 2;
        }
    }

}

