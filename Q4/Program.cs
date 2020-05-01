using System;

namespace Q4
{
    class Program : CoisasUteis
    {
        static void Main ()
        {
            Console.WriteLine ("Digite o valor de linhas: ");
            int i = int.Parse (Console.ReadLine ());
            Console.WriteLine ("Digite o valor de colunas: ");
            int j = int.Parse (Console.ReadLine ());
            int[, ] matriz = new int[i, j];
            matriz = QtdDeCasasNaMatriz (matriz);
            ImprimirMatriz (matriz);
        }
        static int[, ] QtdDeCasasNaMatriz (int[, ] matriz)
        {
            if (matriz.GetLength (0) != matriz.GetLength (1))
            {
                // Reniciar caso a matriz nao seja quadrada
                Console.Clear();
                Console.WriteLine("Digite uma matriz quadrada!");
                Main();
            }
            int sum = 0;
            for (int i = 0; i < matriz.GetLength (1); i++)
            {
                for (int j = 0; j < matriz.GetLength (0); j++)
                {
                    sum++;
                    matriz[j, i] = sum;
                }
            }
            return matriz;
        }
    }
}
