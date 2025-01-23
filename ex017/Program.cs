namespace ex017
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While (expressão lógica). Só vai executar se a expressão for verdadeira.
            // Faça um programa que leia o gênero de uma pessoa, mas só aceite os valor "M" ou "F". Caso esteja errado, peça para digitar novamente.

            string genero;

            Console.Write("Digite o gênero: ");
            genero = Console.ReadLine().ToUpper();

            //ToUpper() - Converte a string para maiúsculo. Função somente para string.

            while (genero != "M" && genero != "F")
            {
                Console.Write("Esse gênero não é válido, digite o gênero novamente: ");
                genero = Console.ReadLine().ToUpper();
            }

            Console.WriteLine("Bem-vindo(a) ao curso de C#!");
        }
    }
}
