using System;

namespace _2lesson_task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sample = Console.ReadLine();
            Console.WriteLine(dontRepeat(sample));
        }
        static string dontRepeat(string provided)
        {
            string withoutRepeat = "";
            int check = 0;
            for(int i = 0; i< provided.Length; i++)
            {
                check = 0;
                for(int j = i-1; j>=0; j--)
                {
                    if(provided[j]==provided[i])
                    {
                        check = 1;
                        break;
                    }
                }
                if(check == 0)
                {
                    withoutRepeat += provided[i];
                }
            }
            return withoutRepeat;
        }
    }
}
