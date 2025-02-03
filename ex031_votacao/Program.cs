namespace ex031_votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa que tenha uma função que receba o ano de nascimento de uma pessoa e retorne se ela pode ou não votar.

            int nasc;
            Console.Write("Digite o ano de nascimento: ");
            nasc = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Voto(nasc));
        }

        static string Voto(int ano)
        {
            DateTime dataAtual = DateTime.Now; // Pega a data atual
            int anoAtual = dataAtual.Year; // Pega o ano atual, esse não colocamos int pois já declaramos no parâmetro
            int idade = anoAtual - ano; // Calcula a idade

            if (idade < 16)
            {
                return $"Com {idade} anos: Voto Negado.";
            }
            else if (idade > 18 && idade < 70)
            {
                return $"Com {idade} anos: Voto Obrigatório.";
            }
            else
            {
                return $"Com {idade} anos: Voto Opcional.";
            }

            /*
            int dia = dataAtual.Day; Pega o dia atual
            int mes = dataAtual.Month;  Pega o mês atual
            int hora = dataAtual.Hour;  Pega a hora atual
            int minuto = dataAtual.Minute; Pega o minuto atual
            int segundo = dataAtual.Second; Pega o segundo atual
            */
        }
    }
}
