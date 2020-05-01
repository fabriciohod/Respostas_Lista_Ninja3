using System;
namespace Q2
{
    class Program : CoisasUteis
    {
        static void Main (string[] args)
        {
            int[, ] matriz = new int[3, 3];
            matriz = PreecherMatriz(matriz);
            ImprimirMatriz (matriz);
            Console.WriteLine ($"\nO maior numero encontrado na matriz e {MaxMatriz(matriz)}");
        }
        static int MaxMatriz (int[, ] matriz)
        {
            int max = matriz[0];
            foreach (var item in matriz)
            {
                if (item > max) max = item;
            }
            return max;
        }
    }
}
