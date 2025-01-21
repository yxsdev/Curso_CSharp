namespace ex011
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sa1;
            
            Console.Write("Escreva o valor do seu salário aqui: ");
            sa1 = Convert.ToDouble(Console.ReadLine());

            if (sa1 > 2500)
            {
                Console.WriteLine("Seu salário é de R$ {0} e com o aumento de 5% passará a ser de R$ {1}", sa1, sa1 * 1.05);
            }
            else if (sa1 > 1250)
            {
                Console.WriteLine("Seu salário é de R$ {0} e com o aumento de 10% passará a ser de R$ {1}", sa1, sa1 * 1.10);
            }
            else
            {
                Console.WriteLine("Seu salário é de R$ {0} e com o aumento de 15% passará a ser de R$ {1}", sa1, sa1 * 1.15);
            }
        }
    }
}
