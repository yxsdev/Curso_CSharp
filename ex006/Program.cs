namespace ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;

            Console.Write("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;

            Console.WriteLine("Média: {0}", media);
        }
    }
}
