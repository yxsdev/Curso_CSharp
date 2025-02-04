namespace ex33_contador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um método que receba dois valores inteiros e um valor de passo e faça a contagem de um valor até o outro de acordo com o passo informado.

            Escrever("Determine uma contagem personalizada: ");

            Console.Write("Início: ");
            int inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Fim: ");
            int fim = Convert.ToInt32(Console.ReadLine());

            Console.Write("Passo: ");
            int passo = Convert.ToInt32(Console.ReadLine());

            Contagem(inicio, fim, passo);
        }

        static void Contagem(int i, int f, int p)
        {
            Escrever($"Contagem de {i} até {f} de {p} em {p}.");

            if (p <0)
            {
                p *= -1;
            }

            if (i < f)
            {
                int cont = i;
                while (cont <= f)
                {
                    Console.Write(cont + " ");
                    Thread.Sleep(500); //Serve para dar um delay de um tempo que eu quiser
                    cont += p;
                }
                Console.WriteLine("Fim!");
            }
            else
            {
                int cont = i;
                while (cont >= f)
                {
                    Console.Write(cont + " ");
                    Thread.Sleep(500);
                    cont -= p;
                }
                Console.WriteLine("Fim!");
            }
        }

        static void Escrever(string texto)
        {
            int tam = texto.Length + 4;
            string linha = new('=', tam);
            string textoCentralizado = texto.PadLeft(tam - 2).PadRight(tam - 2);
            Console.WriteLine(linha);
            Console.WriteLine($"{textoCentralizado}");
            Console.WriteLine(linha);
        }
    }
}
