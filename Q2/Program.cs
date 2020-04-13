using System;
namespace Q2
{
    class Program
    {
        static void Main (string[] args)
        {
            int[, ] matriz = new int[3, 3];
            matriz = PreecherMatrizAutomatico (matriz);
            ImprimirMatriz (matriz);
            Console.WriteLine ($"\nO maior numero encontrado na matriz e {MaxMatriz(matriz)}");
        }
        static int MaxMatriz (int[, ] matriz)
        {
            int max = 0;
            foreach (var item in matriz)
            {
                if (item > max) max = item;
            }
            return max;
        }
        static int[, ] PreecherMatrizAutomatico (int[, ] matriz)
        {
            Random rnd = new Random ();
            for (int i = 0; i < matriz.GetLength (0); i++)
            {
                for (int j = 0; j < matriz.GetLength (1); j++)
                {
                    matriz[i, j] = rnd.Next (1, 10);
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
                    Console.Write ($" {matriz[i,j] }");
                }
                Console.WriteLine ();
            }
        }
    }
}