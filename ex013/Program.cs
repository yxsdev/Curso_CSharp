namespace ex013
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício mais encrementado baseado no ex012

            Console.WriteLine("====================");
            Console.WriteLine("Contagem Regressiva");
            Console.WriteLine("====================");

            for (int i = 10; i > 0; i--)
            {
                Console.Write("{0}, ", i);
            }
        }
    }
}
