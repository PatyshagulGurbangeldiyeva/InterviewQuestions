using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class FindDublicateWord
    {
        public static void Main(string[] args)
        {
            string str = "Hello and Hello my name is John and my Last name is JohnJohn";
            DublictateWord(str);
            Console.ReadLine();
        }

        public static void DublictateWord(string str)
        {
            string [] s = str.Split();

            for (int i=0; i<s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j] && i != j)
                    {
                        Console.WriteLine(s[i]);
                    }
                    
                }
         
            }
          
        }

    }
}
