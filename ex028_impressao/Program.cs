namespace ex028_impressao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            escreva("Yasmin Dantas");
            Console.WriteLine();
            escreva("Tenho 20 anos");
            Console.WriteLine();
            escreva("Moro em São Paulo");
            Console.WriteLine();
        }

        static void escreva(string texto)
        {
            /* Escreve o texto centralizado na tela*/

            char caracter = '='; // Caracter que será impresso
            int tamanho = texto.Length + 4; // O 4 é para adicionar 2 espaços em branco de cada lado
            string linha = new string(caracter, tamanho); // cria uma linha de caracteres
            string centralizado = texto.PadLeft(2 + texto.Length).PadRight(tamanho); // O PadLeft e Padleft manda o texto para esquerda ou direita
            Console.WriteLine(linha);
            Console.WriteLine(centralizado);
            Console.WriteLine(linha);
        }
    }
}
