namespace ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1, m1, multa;

            Console.Write("Digite a velocidade (km/h): ");
            v1 = Convert.ToDouble(Console.ReadLine());

            m1 = v1 - 80;
            multa = m1 * 7.00f;

            if (v1 > 80)
            {
                Console.WriteLine("Você foi multado! A sua multa está no valor de R${0}.", multa);
            }
            else
            {
                Console.WriteLine("Você não foi multado!");
            }

        }
    }
}
