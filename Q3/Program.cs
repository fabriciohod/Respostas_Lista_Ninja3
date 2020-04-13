using System;

namespace q3
{
    class Program
    {
        static void Main (string[] args)
        {
            int[, ] matriz = new int[3, 3];
            (int max, int min) resultado = (0, 0);
            matriz = PreecherMatrizAutomatico (matriz);
            resultado = MaxAndMinMatriz (matriz);
            ImprimirMatriz (matriz);
            Console.WriteLine ($"\nO maior valor {resultado.max}, o menor valor e {resultado.min}");
        }
        static (int, int) MaxAndMinMatriz (int[, ] matriz)
        {
            int max = 0;
            int min = 0;
            foreach (var item in matriz)
            {
                if (item > max)
                {
                    max = item;
                    min = max;
                }
                if (min >= item) min = item;
            }
            return (max, min);
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