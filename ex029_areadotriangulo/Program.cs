namespace ex029_areadotriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a base do triângulo: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Digite a altura do triângulo: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            areaT(b, a);
        }

        static void areaT(double b, double a)
        {
            double t = (b * a) / 2;
            Console.WriteLine($"A área do triângulo {b} x {b} / 2 é de: {t}.");
        }
    }
}
