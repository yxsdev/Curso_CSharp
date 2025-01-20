namespace ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ladoA, ladoB, ladoC;

            Console.Write("Digite o lado A: ");
            ladoA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado B: ");
            ladoB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o lado B: ");
            ladoC = Convert.ToInt32(Console.ReadLine());

            if ((ladoA < ladoB + ladoC) && (ladoB < ladoA + ladoC) && (ladoC < ladoA + ladoB))
            {
                Console.WriteLine("Os lados formam um triângulo.");
            }
            else
            {
                Console.WriteLine("Os lados não formam um triângulo.");
            }
        }
    }
}
