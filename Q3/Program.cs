using System;

namespace q3
{
    class Program : CoisasUteis
    {
        static void Main (string[] args)
        {
            int[, ] matriz = new int[3, 3];
            (int max, int min) resultado = (0, 0);
            matriz = PreecherMatriz (matriz);
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
    }
}