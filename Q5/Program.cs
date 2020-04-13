using System;
using System.Collections.Generic;
using System.Linq;
namespace Q5
{
    class Program
    {
        static void Main (string[] args)
        {
            int[] array = { 1, 1, 2, 3, 1, 4, 4 };
            Dictionary<int, int> NumerosRepetidos = new Dictionary<int, int> ();
            foreach (var item in array)
            {
                if (array.GroupBy (x => x).Any (g => g.Count () > 1) && !NumerosRepetidos.ContainsKey (item)) NumerosRepetidos.Add (item, 0);
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (NumerosRepetidos.ContainsKey (array[i])) NumerosRepetidos[array[i]] += 1;
            }
            var maxValue = NumerosRepetidos.Values.Max ();
            foreach (var item in NumerosRepetidos)
            {
                if (maxValue == item.Value)
                {
                    for (int i = 0; i < item.Value; i++)
                    {
                        Console.Write ($" {item.Key} ");
                    }
                }
            }
            System.Console.WriteLine ();
        }
    }
}