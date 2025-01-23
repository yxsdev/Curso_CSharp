namespace ex012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício de Estrutura de Repetição
            // 1. Faça um algoritmo que imprima os números de 0 a 10 utilizando uma estrutura de repetição.

            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            // O "i++" conta de 1 em 1 até chegar no 11, que é o limite do "for". (Você determina o valor de i). (Também pode ser feito com "i--" para contar de 10 a 0).
        }
    }
}
