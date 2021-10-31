using System;
using System.Collections.Generic;
using System.Text;

namespace Homework5
{
    class task4
    {
        static void Main(string[] args) // Среднее отклонение
        {
            List<double> sp = new List<double>();
            double a = 1;
            while (a != 0)
            {
                a = Convert.ToDouble(Console.ReadLine());
                if (a != 0)
                    sp.Add(a);
            }
            double sum = 0;
            foreach (double i in sp)
                sum += i;
            double S = sum / Convert.ToDouble(sp.Count);
            double q = 0;
            foreach (double i in sp)
                q += Math.Pow(i - S, 2);
            q /= sp.Count - 1;
            Console.WriteLine(Math.Sqrt(q));
        }
    }
}
