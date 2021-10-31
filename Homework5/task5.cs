
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class task5
    {
        static void Main(string[] args) // Кегли
        {
            string NK = Console.ReadLine();
            int N = int.Parse(NK.Split()[0]);
            int K = int.Parse(NK.Split()[1]);
            char[] keg = new char[N];
            for (int i = 0; i < N; i++)
                keg[i] = '|';
            for (int i = 0; i < K; i++)
            {
                string a = Console.ReadLine();
                int li = int.Parse(a.Split()[0]);
                int ri = int.Parse(a.Split()[1]);
                for (int j = li; j <= ri; j++)
                {
                    keg[j - 1] = '.';
                }
            }
            Console.WriteLine(String.Join("", keg));
        }
    }
}
