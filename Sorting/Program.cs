using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unordered list: ");
            List<int> list = new List<int>(100);
            for (int i = 0; i < 100; i++)
            {
                list.Add(Utils.random.Next(100));
                Console.WriteLine(list[i]);
            }

            list = Sort(list);
            Console.WriteLine("Ordered list: ");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static public List<int> Sort(List<int> list)
        {
            List<int> numeros = new List<int>(100);
            numeros = list;


            for (int i = 0; i < numeros.Count; i++)
            {
                for (int j = 0; j < numeros.Count - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j + 1];
                        numeros[j + 1] = numeros[j];
                        numeros[j] = temp;
                    }
                }
            }

            return numeros;
        }
    }
}
