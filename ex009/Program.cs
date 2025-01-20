namespace ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;

            Console.Write("Escreva um número interio: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 % 2 == 0)
            {
                Console.WriteLine("O número {0} é par.", n1);
            }
            else
            {
                Console.WriteLine("O número {0} é ímpar.", n1);
            }
        }
    }
}
