namespace ex025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Métodos são blocos de código que executam uma tarefa específica.
            // soma(3, 4);
            saudacao("Yasmin");
        }

        static void soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine("A soma de " + a + "+" + b + "=" + resultado);
        }

        static void saudacao(string nome)
        {
            Console.WriteLine("Seja Bem Vindo(a), " + nome + "!");
        }
    }
}
