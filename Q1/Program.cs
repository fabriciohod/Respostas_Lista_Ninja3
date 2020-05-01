using System;

namespace Q1
{
    class Program : CoisasUteis
    {
        static void Main (string[] args)
        {
            int[, ] matriz = new int[3, 3];
            matriz = PreecherMatriz (matriz);
            ImprimirMatriz (matriz);
            Console.WriteLine ($"\nA soma dos numeros Impares da Matriz: {SomaDeValores(n => n % 2 == 1, matriz)}");

        }
        static int SomaDeValores (Func<int, bool> filtro, int[, ] matriz)
        {
            int sum = 0;
            foreach (var item in matriz)
            {
                if (filtro (item))
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}