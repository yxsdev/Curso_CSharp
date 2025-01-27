namespace ex019_testesenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa em que o usuário precise digitar uma senha e ao digitar errado ele continue pedindo a senha até que ele acerte com um limite de 3 tentativas.
            
            string senha = "123";
            string senhaDigitada;
            int tentativas = 0;

            do
            {
                Console.Clear(); // Limpa a tela
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;
                if (tentativas > 3) { break; } // Limite de tentativas
            } while (senha != senhaDigitada);

            if (senha != senhaDigitada)
            {
                Console.Clear();
                Console.WriteLine("Senha incorreta! Tentativas: " + tentativas); //Contador de tentativas
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Senha correta! Tentativas: " + tentativas);
            }
        }
    }
}
