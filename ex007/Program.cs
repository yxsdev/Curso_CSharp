using System.ComponentModel.Design;

namespace ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota_final, n1, n2, n3, n4;
            string resultado;

            Console.Write("Digite a nota do 1° semestre: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota do 2° semestre: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota do 3° semestre: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a nota do 4° semestre: ");
            n4 = Convert.ToDouble(Console.ReadLine());

            nota_final = (n1 + n2 + n3 + n4) / 4;

            if (nota_final >= 70)
            {
                resultado = "Aprovado";
                if (nota_final >= 95)
                {
                    resultado = "Aprovado com louvor";
                }
            }
            else if (nota_final >= 45)
            {
                resultado = "Recuperação";
            }
            else
            {
                resultado = "Reprovado";
            }
            

            Console.WriteLine("Condição do aluno: {0} - {1}.", nota_final, resultado);
        }
    }
}
