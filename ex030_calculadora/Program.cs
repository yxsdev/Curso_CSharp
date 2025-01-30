namespace ex030_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int b = Convert.ToInt32(Console.ReadLine());

            soma(a, b);
            multiplicacao(a, b);
            subtracao(a, b);
            divisao(a, b);
        }

        static void soma(int a, int b)
        {
            int r = a + b;
            Console.WriteLine($"{a} + {b} = {r}");
        }

        static void multiplicacao(int a, int b)
        {
            int r = a * b;
            Console.WriteLine($"{a} x {b} = {r}");
        }

        static void subtracao(int a, int b)
        {
            int r = a - b;
            Console.WriteLine($"{a} - {b} = {r}");
        }

        static void divisao(int a, int b)
        {
            int r = a / b;
            Console.WriteLine($"{a} / {b} = {r}");
        }
    }
}

