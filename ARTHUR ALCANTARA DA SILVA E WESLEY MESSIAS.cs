using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeInterdisciplinar
{
    internal class Program
    {
        //ATIVIDADE FEITA EM DUPLA
        //MEMBROS: ARTHUR ALCANTARA DA SILVA E WESLEY MESSIAS
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
                Console.WriteLine("=================================================");
                Console.WriteLine("          SISTEMA DE CONVERSÃO DE BASES          ");
                Console.WriteLine("=================================================");
                Console.WriteLine("  1. Decimal ──► Binário                         ");
                Console.WriteLine("  2. Binário ──► Decimal                         ");
                Console.WriteLine("  3. Decimal ──► Octal                           ");
                Console.WriteLine("  4. Octal   ──► Decimal                         ");
                Console.WriteLine("  5. Decimal ──► Hexadecimal                     ");
                Console.WriteLine("  6. Hexadecimal ──► Decimal                     ");
                Console.WriteLine("  7. Binário ──► Octal                           ");
                Console.WriteLine("  8. Octal   ──► Binário                         ");
                Console.WriteLine("  9. Binário ──► Hexadecimal                     ");
                Console.WriteLine(" 10. Hexadecimal ──► Binário                     ");
                Console.WriteLine(" 11. Octal   ──► Hexadecimal                     ");
                Console.WriteLine(" 12. Hexadecimal ──► Octal                       ");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("  0. Sair do Programa                            ");
                Console.WriteLine("=================================================");
                Console.Write(" ➔ Escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("=================================================");

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.Write("[Entrada] Digite o número DECIMAL para converter: ");
                        if (long.TryParse(Console.ReadLine(), out long num) && num >= 0)
                        {
                            Console.WriteLine($"\n[Sucesso] Resultado Final: {DecimalParaBinario(num)}");
                        }
                        else
                        {
                            Console.WriteLine("\n[Erro] Valor inválido! Certifique-se de digitar um número positivo.");
                        }
                        break;

                    case 2:
                        Console.Clear();
                        Console.Write("[Entrada] Digite o número BINÁRIO para converter: ");
                        if (long.TryParse(Console.ReadLine(), out long nume))
                        {
                            Console.WriteLine($"\n[Sucesso] Resultado Final: {BinarioParaDecimal(nume)}");
                        }
                        break;

                    case 3:
                        Console.Clear();
                        Console.Write("🔢 [Entrada] Digite o número DECIMAL para converter: ");
                        if (long.TryParse(Console.ReadLine(), out num) && num >= 0)
                        {
                            Console.WriteLine($"\n [Sucesso] Resultado Final: {DecimalParaOctal(num)}");
                        }
                        else
                        {
                            Console.WriteLine("\n [Erro] Valor inválido! Certifique-se de digitar um número positivo.");
                        }
                        break;

                    case 4:
                        Console.Clear();
                        Console.Write(" [Entrada] Digite o número OCTAL para converter: ");
                        if (long.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"\n [Sucesso] Resultado Final: {OctalParaDecimal(num)}");
                        }
                        else
                        {
                            Console.WriteLine("\n [Erro] Valor inválido!");
                        }
                        break;

                    case 5:
                        Console.Clear();
                        Console.Write(" [Entrada] Digite o número DECIMAL para converter: ");
                        if (long.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"\n [Sucesso] Resultado Final: {DecimalParaHexadecimal(num)}");
                        }
                        else
                        {
                            Console.WriteLine("\n [Erro] Valor inválido!");
                        }
                        break;

                    case 6:
                        Console.Clear();
                        string input = "";
                        Console.Write("[Entrada] Digite o número HEXADECIMAL para converter: ");
                        input = Console.ReadLine();
                        Console.WriteLine($"\n [Sucesso] Resultado Final: {HexadecimalParaDecimal(input)}");
                        break;

                    case 7:
                        Console.Clear();
                        Console.Write("[Entrada] Digite o número BINÁRIO para converter: ");
                        num = long.Parse(Console.ReadLine());
                        Console.WriteLine($"\n [Sucesso] Resultado Final: {BinarioParaOctal(num)}");
                        break;

                    case 8:
                        Console.Clear();
                        Console.Write("[Entrada] Digite o número OCTAL para converter: ");
                        num = long.Parse(Console.ReadLine());
                        Console.WriteLine($"\n [Sucesso] Resultado Final: {OctalParaBinario(num)}");
                        break;

                    case 9:
                        Console.Clear();
                        Console.Write("[Entrada] Digite o número BINÁRIO para converter: ");
                        if (long.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"\n [Sucesso] Resultado Final: {BinarioParaHexadecimal(num)}");
                        }
                        else
                        {
                            Console.WriteLine("\n [Erro] Valor inválido!");
                        }
                        break;

                    case 10:
                        Console.Clear();
                        Console.Write("[Entrada] Digite o número HEXADECIMAL para converter: ");
                        input = Console.ReadLine();
                        Console.WriteLine($"\n [Sucesso] Resultado Final: {HexadecimalParaBinario(input)}");
                        break;

                    case 11:
                        Console.Clear();
                        Console.Write("[Entrada] Digite o número OCTAL para converter: ");
                        if (long.TryParse(Console.ReadLine(), out num))
                        {
                            Console.WriteLine($"\n [Sucesso] Resultado Final: {OctalParaHexadecimal(num)}");
                        }
                        break;

                    case 12:
                        Console.Clear();
                        Console.Write("[Entrada] Digite o número HEXADECIMAL para converter: ");
                        input = Console.ReadLine();
                        Console.WriteLine($"\n[Sucesso] Resultado Final: {HexadecimalParaOctal(input)}");
                        break;

                    default:
                        break;
                }
                Console.WriteLine("\n-------------------------------------------------");
                Console.WriteLine(" ➔ Pressione qualquer tecla para voltar ao menu...");
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

            Console.WriteLine("\n⚙️ [Processando] Executando divisões sucessivas por 2:");

            for (int i = 0; num > 0; i++)
            {
                quociente = DivisaoPorDois(num);
                resto = RestoPorDois(num);
                Console.WriteLine($"   └─► Passo {i + 1}: {num} / 2 ➔ Quociente: {quociente} | Resto: {resto}");
                num = quociente;

                valorFinal[i] = resto;
                cont++;

                if (num == 0)
                {
                    Console.WriteLine($"   └─► Passo {i + 2}: Invertendo e juntando os restos encontrados.");
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
                    Console.WriteLine("\n❌ [Erro] Valor inválido! Por favor escreva apenas algarismos 0 e 1!");
                    return -1;
                }
            }

            long resultadoDecimal = 0;
            int pesoBase = 1;
            int passo = 1;

            Console.WriteLine($"\n⚙️ [Processando] Analisando o binário: {temp}");

            for (int j = temp.Length - 1; j >= 0; j--)
            {
                int digitoBinario = temp[j] - '0';

                long termoMultiplicado = digitoBinario * pesoBase;
                resultadoDecimal += termoMultiplicado;
                Console.WriteLine($"   └─► Passo {passo}: ({digitoBinario} * 2^{passo - 1}) ➔ {termoMultiplicado}");

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
            Console.WriteLine("\n⚙️ [Processando] Executando divisões sucessivas por 8:");

            for (int i = 0; num > 0; i++)
            {
                quociente = num / 8;
                resto = num % 8;

                Console.WriteLine($"   └─► Passo {i + 1}: {num} / 8 ➔ Quociente: {quociente} | Resto: {resto}");
                num = quociente;

                resultadoOctal[i] = resto;
                cont++;

                mostrarPassos = mostrarPassos + (i + 1);
                if (num == 0)
                {
                    Console.WriteLine($"   └─► Passo {i + 2}: Agrupando em ordem inversa os restos dos passos: {mostrarPassos}");
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
                    Console.WriteLine("\n❌ [Erro] Valor inválido! Escreva apenas dígitos entre 0 e 7!");
                    return -1;
                }
            }

            long resultadoDecimal = 0;
            int pesoBase = 1;
            int passo = 1;

            Console.WriteLine($"\n⚙️ [Processando] Analisando o octal: {temp}");

            for (int j = temp.Length - 1; j >= 0; j--)
            {
                int digitoOctal = temp[j] - '0';

                long termoMultiplicado = digitoOctal * pesoBase;
                resultadoDecimal += termoMultiplicado;
                Console.WriteLine($"   └─► Passo {passo}: ({digitoOctal} * 8^{passo - 1}) ➔ {termoMultiplicado}");

                if (j == 0)
                {
                    Console.WriteLine($"   └─► Passo {passo + 1}: Somando todos os valores calculados.");
                }

                pesoBase *= 8;
                passo++;
            }

            return resultadoDecimal;
        }

        static string DecimalParaHexadecimal(long num)
        {
            if (num == 0) return "0";

            int cont = -1;
            char[] valorHexadecimal = new char[1000000];

            long resto = 0;
            long quociente = 0;

            Console.WriteLine("\n⚙️ [Processando] Executando divisões sucessivas por 16:");

            for (int i = 0; num > 0; i++)
            {
                quociente = num / 16;
                resto = num % 16;
                Console.WriteLine($"   └─► Passo {i + 1}: {num} / 16 ➔ Quociente: {quociente} | Resto: {resto}");
                num = quociente;

                if (resto == 10) valorHexadecimal[i] = 'A';
                else if (resto == 11) valorHexadecimal[i] = 'B';
                else if (resto == 12) valorHexadecimal[i] = 'C';
                else if (resto == 13) valorHexadecimal[i] = 'D';
                else if (resto == 14) valorHexadecimal[i] = 'E';
                else if (resto == 15) valorHexadecimal[i] = 'F';
                else valorHexadecimal[i] = Convert.ToChar(resto + 48);

                cont++;

                if (num == 0)
                {
                    Console.WriteLine($"   └─► Passo {i + 2}: Mapeando restos maiores que 9 para letras (A-F) e invertendo a ordem.");
                }
            }

            string resultado = "";

            for (int i = cont; i >= 0; i--)
            {
                resultado += Convert.ToChar(valorHexadecimal[i]);
            }

            return resultado;
        }

        static long HexadecimalParaDecimal(string num)
        {
            string temp = num.ToUpper();

            for (int i = 0; i < temp.Length; i++)
            {
                if (!((temp[i] >= '0' && temp[i] <= '9') || (temp[i] >= 'A' && temp[i] <= 'F')))
                {
                    Console.WriteLine("\n❌ [Erro] Valor inválido! Use apenas números de 0 a 9 e letras de A a F!");
                    return -1;
                }
            }

            long resultadoDecimal = 0;
            int pesoBase = 1;
            int passo = 1;

            Console.WriteLine($"\n⚙️ [Processando] Analisando o hexadecimal: {temp}");

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

                Console.WriteLine($"   └─► Passo {passo}: ({digitoHexaDecimal} * 16^{passo - 1}) ➔ {termoMultiplicado}");

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
                    Console.WriteLine("\n❌ [Erro] Valor inválido! Use apenas 0 e 1.");
                    return -1;
                }
            }

            Console.WriteLine("\n🔀 [Ponte] Iniciando conversão composta (Binário ──► Decimal ──► Octal):");
            
            Console.WriteLine("\n[Etapa 1/2] Convertendo de Binário para Decimal:");
            long binarioDecimal = BinarioParaDecimal(long.Parse(temp));
            
            Console.WriteLine($"\n[Etapa 2/2] Convertendo o valor Decimal ({binarioDecimal}) para Octal:");
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
                    Console.WriteLine("\n❌ [Erro] Valor inválido! Use apenas valores entre 0 e 7.");
                    return -1;
                }
            }

            Console.WriteLine("\n🔀 [Ponte] Iniciando conversão composta (Octal ──► Decimal ──► Binário):");

            Console.WriteLine("\n[Etapa 1/2] Convertendo de Octal para Decimal:");
            long octalParaDecimal = OctalParaDecimal(num);
            
            Console.WriteLine($"\n[Etapa 2/2] Convertendo o valor Decimal ({octalParaDecimal}) para Binário:");
            long resultFinal = DecimalParaBinario(octalParaDecimal);

            return resultFinal;
        }

        static string BinarioParaHexadecimal(long num)
        {
            string temp = Convert.ToString(num);

            for (int i = 0; i < temp.Length; i++)
            {
                if (Convert.ToInt32(temp[i]) != 48 && Convert.ToInt32(temp[i]) != 49)
                {
                    Console.WriteLine("\n❌ [Erro] Valor inválido! Use apenas 0 e 1.");
                    break;
                }
            }

            Console.WriteLine("\n🔀 [Ponte] Iniciando conversão composta (Binário ──► Decimal ──► Hexadecimal):");

            Console.WriteLine("\n[Etapa 1/2] Convertendo de Binário para Decimal:");
            long binarioParaDecimal = BinarioParaDecimal(num);
            
            Console.WriteLine($"\n[Etapa 2/2] Convertendo o valor Decimal ({binarioParaDecimal}) para Hexadecimal:");
            string resultado = DecimalParaHexadecimal(binarioParaDecimal);

            return resultado;
        }

        static long HexadecimalParaBinario(string num)
        {
            string temp = num.ToUpper();

            Console.WriteLine("\n🔀 [Ponte] Iniciando conversão composta (Hexadecimal ──► Decimal ──► Binário):");

            Console.WriteLine("\n[Etapa 1/2] Convertendo de Hexadecimal para Decimal:");
            long HexaParaDeci = HexadecimalParaDecimal(temp);

            Console.WriteLine($"\n[Etapa 2/2] Convertendo o valor Decimal ({HexaParaDeci}) para Binário:");
            long resultado = DecimalParaBinario(HexaParaDeci);

            return resultado;
        }

        static string OctalParaHexadecimal(long num)
        {
            Console.WriteLine("\n🔀 [Ponte] Iniciando conversão composta (Octal ──► Decimal ──► Hexadecimal):");

            Console.WriteLine("\n[Etapa 1/2] Convertendo de Octal para Decimal:");
            long octalParaDecimal = OctalParaDecimal(num);
            
            Console.WriteLine($"\n[Etapa 2/2] Convertendo o valor Decimal ({octalParaDecimal}) para Hexadecimal:");
            string decimalParaHexadecimal = DecimalParaHexadecimal(octalParaDecimal);

            return decimalParaHexadecimal;
        }

        static long HexadecimalParaOctal(string num)
        {
            Console.WriteLine("\n🔀 [Ponte] Iniciando conversão composta (Hexadecimal ──► Binário ──► Octal):");

            Console.WriteLine("\n[Etapa 1/2] Convertendo de Hexadecimal para Binário:");
            long hexaParaBinario = HexadecimalParaBinario(num);
            
            Console.WriteLine($"\n[Etapa 2/2] Convertendo o valor Binário ({hexaParaBinario}) para Octal:");
            long binarioParaOctal = BinarioParaOctal(hexaParaBinario);

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