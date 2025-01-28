namespace ex021_vetoresdedatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa que mostre o último dia de cada mês.

            string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio","Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
            int[] dias = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            for (int i = 0; i < meses.Length; i++)
            {
                Console.WriteLine("O mês de " + meses[i] + " tem " + dias[i] + " dias.");
            }

            Console.WriteLine();



            string[] semana = { "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sábado" };

            foreach (string dia in semana) // foreach não traz o indice ele traz o valor e só conseguimos trabalhar com um vetor por vez
            {
                Console.WriteLine(dia);
            }

            Console.WriteLine();

            foreach (string mes in meses)
            {
                Console.WriteLine(mes);
            }   


        }
    }
}
