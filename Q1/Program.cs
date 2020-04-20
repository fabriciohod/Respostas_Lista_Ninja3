using System;

namespace Q1
{
    class Program
    {
        public delegate bool MyDelegate (int n);
        static void Main (string[] args)
        {
            int[, ] matriz = new int[3, 3];
            matriz = PreecherMatrizUsiario (matriz);
            ImprimirMatriz (matriz);
            Console.WriteLine ($"\nA soma dos numeros Impares da Matriz: {SomaDeValores(n => n % 2 == 1, matriz)}");

        }
        static int SomaDeValores (MyDelegate filtro, int[, ] matriz)
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
        static int[, ] PreecherMatrizUsiario (int[, ] matriz)
        {
            Random rnd = new Random ();
            for (int i = 0; i < matriz.GetLength (0); i++)
            {
                for (int j = 0; j < matriz.GetLength (1); j++)
                {
                    Console.WriteLine ($"Digite um numro para a posicao {i}, {j} ");
                    matriz[i, j] = int.Parse (Console.ReadLine ());
                }
            }
            return matriz;
        }
        // Estava usando essa para testar
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