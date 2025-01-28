using System.Diagnostics.Metrics;

namespace ex022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa usando o vetor de uma lista de frutas e outro vetor com o preço de cada fruta. Mostre na tela a primeira e a última fruta, a fruta mais cara e a mais barata, e o preço de cada fruta.


            string[] fruta = { "Banana", "Maçã", "Uva", "Laranja", "Mamão", "Abacate", "Limão", "Abacaxi", "Morango", "Caju" };
            double[] valor = { 3.50, 2.80, 4.90, 3.20, 2.30, 5.10, 2.90, 3.00, 4.00, 6.00 };

            string fruta_primeiro = fruta.First();
            string fruta_ultimo = fruta.Last();

            Console.WriteLine("A primeira fruta é: " + fruta_primeiro + ".");
            Console.WriteLine("A última fruta é: " + fruta_ultimo + ".");

            Console.WriteLine();

            string fruta_maior = fruta.Max();  
            string fruta_menor = fruta.Min();  

            Console.WriteLine("A primeira fruta em ordem alfabética é: " + fruta_menor + ".");
            Console.WriteLine("A última fruta em ordem alfabética é: " + fruta_maior + ".");

            Console.WriteLine();

            double valor_maior = valor.Max();
            double valor_menor = valor.Min();

            Console.WriteLine("A fruta mais cara custa R$" + valor_maior + ".");
            Console.WriteLine("A fruta mais barata custa R$" + valor_menor + ".");

            Console.WriteLine();

            for (int i = 0; i < fruta.Length; i++)
            {
                Console.WriteLine("A fruta " + fruta[i] + " custa R$" + valor[i] + ".");
            }
        }
    }
}
