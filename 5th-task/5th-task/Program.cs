using System;

namespace _5th_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine()), mult=1, sum =0;
            for(int i = 1; i<n; i++)
            {
                mult *= i;
                sum += i;
            }
            Console.WriteLine(mult - sum);
        }
    }
}
