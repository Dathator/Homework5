using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class task3
    {
        static void Main(string[] args) // Степень числа М
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (Math.Pow(N, i) != M)
            {
                i++;
                if (Math.Pow(N, i) > M)
                {
                    Console.WriteLine("NO");
                    break;
                }
                else if (Math.Pow(N, i) == M)
                {
                    Console.WriteLine("YES");
                    break;
                }
            }
        }
    }
}
