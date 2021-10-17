using System;

namespace _2ndLesson_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int beginPoint = Convert.ToInt32(Console.ReadLine()), stringLength;
            try {
                stringLength = Convert.ToInt32(Console.ReadLine());

            }
            catch {
                stringLength = s.Length-beginPoint;
            }

            
            Console.WriteLine(SubString(s, beginPoint, stringLength));
        }
        static string SubString(string mainWord, int beginPoint, int stringLength)
        {
            string sub="";
            if(stringLength == null)
            {
                for(int i = beginPoint; i<mainWord.Length; ++i)
                {
                    sub += mainWord[i];
                }
                return sub;
            }
            else
            {
                for (int i = beginPoint; i < beginPoint + stringLength; ++i)
                {
                    sub += mainWord[i];
                }
                return sub;
            };

        }

    }
}
