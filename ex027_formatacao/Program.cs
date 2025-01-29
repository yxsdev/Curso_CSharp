namespace ex027_formatacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10.54823;
            double num2 = 7890.98756;

            // Formatação de números

            // Formatação de números para reduzir casas decimais
            Console.WriteLine($"{num1:F2}");

            // Formatação de números com separador de milhar
            Console.WriteLine($"{num2:N2}");

            // Formatação de números para moeda(Real pois está em português)
            Console.WriteLine($"{num1:C2}");

            // Formatação de números para exponencial
            Console.WriteLine($"{num2:E2}");

            // Formatação de números para porcentagem
            Console.WriteLine($"{num1:P2}");
        }
    }
}
