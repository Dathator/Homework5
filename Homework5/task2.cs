using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class task2
    {
        static void Main(string[] args) // Сортировка
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            int[] sor = new int[n];
            string[] a = Console.ReadLine().Split();
            for (int i = 0; i < a.Length; i++)
            { 
                mas[i] = int.Parse(a[i]);
                sor[i] = int.Parse(a[i]);
            }
            Array.Sort(sor);
            for (int i = 0; i < n; i++)
            {
                Console.Write(sor[0] + " ");
                sor[0] = sor[n - 1];
                Array.Sort(sor);
            }
        }
    }
}
