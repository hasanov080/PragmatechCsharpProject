using System;

namespace _1st_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, sum=0;
            for(int i = 0; i < 5; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                sum += x;
            }
            Console.WriteLine(sum / 5);

        }
    }
}
