namespace ex024_metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Métodos são blocos de código que executam uma tarefa específica.
            soma (3, 4);
        }
        static void soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine("A soma de " + a + "+" + b + "=" + resultado);
        }
    }
}
