
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
            Console.Write("|opção:                                       |");
            opcao = int.Parse(Console.ReadLine()); 
            Console.WriteLine("|---------------------------------------------|");

            switch(opcao)
            {
                case 1:
                long num = 0;
                DecimalParaBinario(num);
                break;
                default:
                break;
            }
        }while(opcao != 0);
    }

    static void DecimalParaBinario(long num)
    {
        Console.WriteLine("Informe um número decimal para ser convertido para binário: ");
        num = long.Parse(Console.ReadLine());

        long resto = 0;
        long quociente = 0;

        for (int i = 1; quociente > 0; i++)
        {
            Console.WriteLine($"Passo {i}: {num} / 2 -> Quociente: {DivisaoPorDois(quociente)}, Resto: {RestoPorDois(resto)}");

        }
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

