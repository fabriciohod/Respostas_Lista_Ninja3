using System;
    public class CoisasUteis
    {
        public static int[, ] PreecherMatriz (int[, ] matriz, bool aleatorio = false)
        {
            Random rnd = new Random ();

            for (int i = 0; i < matriz.GetLength (0); i++)
            {
                for (int j = 0; j < matriz.GetLength (1); j++)
                {
                    switch (aleatorio)
                    {
                        case true:
                            matriz[i, j] = rnd.Next (1, 10);
                            break;
                        default:
                            Console.WriteLine ($"Digite um numro para a posicao {i}, {j} ");
                            matriz[i, j] = int.Parse (Console.ReadLine ());
                            break;
                    }
                }
            }
            return matriz;
        }
        public static void ImprimirMatriz (int[, ] matriz)
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