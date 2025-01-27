namespace ex020_vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercícios sobre Vetores

            //Forma 1

            /*
            int[] num = new int[5];

            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
            num[3] = 40;
            num[4] = 50;

            Console.WriteLine(num[0]);


            //Forma 2

            int[] n = new int[3] { 1, 2, 3 };

            Console.WriteLine(n[0]);


            //Forma 3

            int[] numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine(numero[0]);


            //Para aparecer todos os valores do vetor

            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(number[i] + " " + i); //O i é para mostrar a posição do vetor, aqui é mostrado o valor do vetor e a posição dele
            }
            

            //Usando o double

            double[] reais = { 1.1, -2.2, 3.3, -4.4, 5.5, 6.6, -7.7};

            for (int i = 0; i < reais.Length; i++) //O Length é para mostrar o tamanho do vetor, e é trabalhando com vetores é sempre usando "<".
            {
                Console.WriteLine(reais[i]);
            }

            double reais_maior = reais.Max(); //O Max é para mostrar o maior valor do vetor
            double reais_menor = reais.Min(); //O Min é para mostrar o menor valor do vetor

            Console.WriteLine("O maior valor é: " + reais_maior);
            Console.WriteLine("O menor valor é: " + reais_menor);
            */

            //Usando o string
            string[] nomes = { "Maria", "João", "José", "Pedro", "Ana", "Carlos", "Marta", "Paulo", "Lucas", "Mariana" };

            for (int i = 0; i < nomes.Length; i++)
            {
                if (i < nomes.Length - 1) //O "-1" é para não aparecer a vírgula no último nome
                {
                    Console.Write(nomes[i] + ", ");
                }
                else
                {
                    Console.Write(nomes[i] + ".");
                }
            }
        }
    }
}
