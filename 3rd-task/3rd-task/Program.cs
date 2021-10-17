using System;

namespace _3rd_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<=10; ++i)
            {
                Console.WriteLine("{0}*{1}={2}", a, i, a * i);
            }

        }
    }
}
