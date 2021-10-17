using System;

namespace _2nd_task
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()), b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0} {1}", a * b, 2*(a + b)) ;
        }
    }
}
