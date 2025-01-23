namespace ex016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faça a tabuada de um número que o usuário escolher, só que utilizando um laço for.

            int num1, mult;

            Console.Write("Digite um número: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                mult = num1 * i;
                Console.WriteLine("{0} x {1} = {2}", num1, i, mult);
            }
        }
    }
}
