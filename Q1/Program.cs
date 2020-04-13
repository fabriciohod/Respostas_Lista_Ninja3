﻿using System;

namespace Q1
{
    class Program
    {
        public delegate bool MyDelegate (int n);
        static void Main (string[] args)
        {
            int[, ] matriz = new int[3, 3];
            matriz = PreecherMatriz (matriz);
            ImprimirMatriz (matriz);
            Console.WriteLine ($"\nA soma dos numeros Impares da Matriz: {FiltroParaMatiz(n => n % 2 == 1, matriz)}");

        }
        static int FiltroParaMatiz (MyDelegate filtro, int[, ] matriz)
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
        static int[, ] PreecherMatriz (int[, ] matriz)
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