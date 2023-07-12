using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Media
    {
        static public void VerificarValor()
        {
            try
            {
                double nota;
                double notas;
                double soma = 0;
                for (notas = 1; notas <= 4; notas++)
                {
                    Console.WriteLine($"Digite a nota {notas}");
                    while (!double.TryParse(Console.ReadLine(), out nota))
                    {
                        Console.WriteLine($"O valor deve ser um número!");
                    }
                    soma += nota;
                }
                var media = CalcularMedia(soma);
                ImprimeResultado(media);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Código executado inadequadamente! " + ex.Message);
                Console.ReadLine();
            }
        }

        static public double CalcularMedia(double soma)
        {
            double media = soma / 4;

            return media;
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
