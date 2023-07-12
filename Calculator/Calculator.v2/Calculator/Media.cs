using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Calculator
{
    internal class Media
    {
        static public void CalcularMedia()
        {
            try
            {
                double nota;
                double notas;
                double soma = 0;

                Console.Write("Informe quantas notas serão calculadas por favor: ");
                int qtdeNotas = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                for (notas = 1; notas <= qtdeNotas; notas++)
                {
                    Console.WriteLine($"Digite a nota {notas}");
                    while (!double.TryParse(Console.ReadLine(), out nota))
                    {
                        Console.WriteLine($"O valor deve ser um número!");
                    }
                    soma += nota;
                }

                var media = soma / qtdeNotas;
                ImprimeResultado(media);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Código executado inadequadamente! " + ex.Message);
                Console.ReadLine();
            }
        }
        static public void ImprimeResultado(double media)
        {
            if (media >= 6)
            {
                Console.WriteLine("Você passou de série.");
            }
            else
            {
                Console.WriteLine("Você foi reprovado.");
            }
            Console.WriteLine($"A sua média foi {media}");
            Console.ReadLine();
        }
    }

}
