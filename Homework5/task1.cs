using System;
using System.Collections.Generic;

namespace Homework5
{
    class task1
    {
        static void Main(string[] args) // Одиночные элементы
        {
            int n = int.Parse(Console.ReadLine());
            string[] mas = new string[n];
            string a = Console.ReadLine();
            for (int i = 0; i < a.Split().Length; i++)
            {
                mas[i] = a.Split()[i];
            }
            foreach (string i in mas)
            {
                int k = 0;
                foreach (string j in mas)
                {
                    if (i == j)
                        k++;
                }
                if (k == 1)
                    Console.Write(i + " ");
            }
        }
    }
}
