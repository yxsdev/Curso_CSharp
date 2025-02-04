namespace ex32_fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa que calcule o fatorial de um número inteiro fornecido pelo usuário.

            int num;
            char resp;
            bool mostrar = false;

            Console.Write("Digite um número inteiro: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Deseja mostrar o cálculo? (s/n): ");
            resp = Convert.ToChar(Console.ReadLine().ToLower());
            Console.WriteLine();

            if (resp == 's') { mostrar = true;  }

            Console.WriteLine(Fatorial(num, mostrar));

        }

        static int Fatorial(int n, bool show=false)
        {
            int f = 1;

            for (int i = 1; i <= n; i++)
            {
                if (show)
                {
                    Console.Write(i);
                    if (i < n)
                    {
                        Console.Write(" x ");
                    }
                    else
                    {
                        Console.Write(" = ");
                    }
                }

                f *= i;
            }

            return f;
        }
    }
}
