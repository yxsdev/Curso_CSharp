namespace ex023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Matriz é como uma tabela, onde temos linhas e colunas

            int[,] matriz = new int[4, 3]; //o primeiro número é a quantidade de linhas e o segundo é a quantidade de colunas

            matriz[0, 0] = 10;
            matriz[0, 1] = 20;
            matriz[0, 2] = 30;

            matriz[1, 0] = 40;
            matriz[1, 1] = 50;
            matriz[1, 2] = 60;

            matriz[2, 0] = 70;
            matriz[2, 1] = 80;
            matriz[2, 2] = 90;

            matriz[3, 0] = 100;
            matriz[3, 1] = 110;
            matriz[3, 2] = 120;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine(matriz.GetLength(0)); //número de linhas
            Console.WriteLine(matriz.GetLength(1)); //número de colunas

        }
    }
}
