using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class DeleteDublicateWords
    {
        public static void Main(string[] args)
        {
            string str = "Hello my name is, name is John and and I am am tall";
            DeleteDublicateWord(str);
            Console.ReadLine();
        }

        // I tried to add strings to set but it did not work!!! look to collection in c#
        public static void DeleteDublicateWord(string str)
        {
            HashSet <string> unique = new HashSet<string>();
           
            string [] words = str.Split();

            for (int i = 0; i < words.Length; i++)
            {
               
                    unique.Add(words[i]);
                
            }
            Console.WriteLine(unique);
        }
    }
}
