using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class FizzBuzz
    {
        /** 
        Print the numbers 1..100
        For multiples of 3, print "Fizz" instead of the number
        For multiples of 5, print "Buzz" instead of the number
        For multiples of 3 and 5, print "FizzBuzz" instead of the number
        
    **/
        public static void Main(string[] args)
        {
            FizBuz (20);
            Console.ReadLine();
        }

        public static void FizBuz(int num)
        { 
            for (int i=1; i<=num; i++) 
            {
                if (i % 3 == 0 && i %5 !=0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0 && i % 3 !=0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizBuzz");
                }
                else
                {
                    Console.WriteLine(i);

                }
            }

        }

    }
}
