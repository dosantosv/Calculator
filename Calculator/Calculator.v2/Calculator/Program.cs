using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Somar();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtraçao");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Multiplicação");
            Console.WriteLine("5 - Calcular Média");
            Console.WriteLine("0 - SAIR");
            Console.WriteLine("------------------");


            ConsoleKeyInfo key = Console.ReadKey(true);
            int res;

            if (int.TryParse(key.KeyChar.ToString(), out res))
            {
                switch (res)
                {
                    case 1: Soma(); break;
                    case 2: Subtracao(); break;
                    case 3: Divisao(); break;
                    case 4: Multiplicacao(); break;
                    case 5: Media.CalcularMedia(); break;
                    case 0: System.Environment.Exit(0); break;
                    default: Menu(); break;
                }
            } else
            {
                Console.WriteLine("Opção inválida! Digite um número válido.");
                Console.ReadKey();
                Menu();
            }

        }
        static void Soma()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            float resultado = v1 + v2;
            Console.WriteLine($"O resultado da soma é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Subtracao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 - v2;
            Console.WriteLine($"O resultado da subtração é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Divisao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 / v2;
            Console.WriteLine($"O resultado da divisão é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Multiplicacao()
        {
            Console.Clear();

            Console.WriteLine("Primeiro valor:");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Segundo valor:");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float resultado = v1 * v2;
            Console.WriteLine($"O resultado da multiplicação é {resultado}");
            Console.ReadKey();
            Menu();
        }
        static void Somar()
        {
            try
            {
                double numero;
                double numeros;
                double soma = 0;

                Console.Write("Informe quantos número serão somados por favor: ");
                double qtdeNotas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                for (numeros = 1; numeros <= qtdeNotas; numeros++)
                {
                    Console.WriteLine($"Digite o valor {numeros}");
                    while (!double.TryParse(Console.ReadLine(), out numero))
                    {
                        Console.WriteLine($"O valor deve ser um número!");
                    }
                    soma += numero;
                }

                var numerosSomados = soma;
                Console.WriteLine($"O valor somado é: {numerosSomados}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Código executado inadequadamente! " + ex.Message);
                Console.ReadLine();
            }
        }
    }
}