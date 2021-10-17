using System;

namespace _2ndlesson_3rdtask
{
    class Program
    {
        static void Main(string[] args)
        {
            string polindrom = Console.ReadLine();
            Console.WriteLine(isPolindrom(polindrom));
        }
        static bool isPolindrom(string check)
        {
            if (ReverseString(check) == check)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        static string ReverseString(string provided)
        {
            string reverse = "";
            for (int i = provided.Length - 1; i >= 0; i--)
            {
                reverse += provided[i];
            }
            return reverse;
        }
    }
}
