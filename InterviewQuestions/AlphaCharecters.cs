using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace InterviewQuestions
{
    class AlphaCharecters
    {
        public static void Main(string[] args)
        {

            // why both of them cannot be run????
            //when I am running just first code is executed
            //
            Alpha("hello 12355/sjhd");
            Numeric("hjfhjshfjkh 128404 /&eks");
        }


        public static void Alpha(string str)
        {
            // in order to remove Numeric and normal characters
            Regex s = new Regex("[0-9 /]");
             str=s.Replace(str, "");
            Console.WriteLine(str);
            Console.ReadLine();
        }
        public static void Numeric(string str)
        {
            // removing nunNumeric characters
            Regex i = new Regex("[a-zA-Z /&]");
            str=i.Replace(str, "");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
