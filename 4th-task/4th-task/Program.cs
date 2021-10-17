using System;

namespace _4th_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()), sum =0;
            for(int i =1; i<=a;i++)
            {
                sum += i * i;
            }
            Console.WriteLine(sum);
        }
    }
}
