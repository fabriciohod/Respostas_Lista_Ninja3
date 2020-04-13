using System;

namespace Q4
{
    class Program
    {
        static void Main (string[] args)
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
            int sum = 0;
            if (matriz.GetLength (0) != matriz.GetLength (1)) throw new ArgumentException ("Digite uma matriz quadrada");
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
        static void ImprimirMatriz (int[, ] matriz)
        {
            System.Console.WriteLine (" Matriz:");
            for (int i = 0; i < matriz.GetLength (0); i++)
            {
                for (int j = 0; j < matriz.GetLength (1); j++)
                {
                    Console.Write ($" |{matriz[i,j] }|");
                }
                Console.WriteLine ();
            }
        }
    }
}