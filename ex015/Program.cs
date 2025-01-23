using System.Runtime.Serialization.Formatters;

namespace ex015
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa que calcule e some os valores múltiplos de 3 entre o intervalo de 1 a 500.

            int soma, cont;

            soma = cont = 0;

            for (int i = 1; i <= 500; i++)
            {
                if (i % 3 == 0)
                {
                    soma += i;
                    cont++;
                }
            }

            Console.WriteLine("A soma dos {0} valores solicitados é {1}", cont, soma);

        }
    }
}
