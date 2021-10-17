using System;

namespace _2ndlesson_2ndtask
{
    class Program
    {
        static void Main(string[] args)
        {
            string provided = Console.ReadLine();
            Console.WriteLine(ReverseString(provided));
        }
        static string ReverseString(string provided)
        {
            string reverse = "";
            for(int i = provided.Length - 1; i>=0; i--)
            {
                reverse += provided[i];
            }
            return reverse;
        }
    }
}
