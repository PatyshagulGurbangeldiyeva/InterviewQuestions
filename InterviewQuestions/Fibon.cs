using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class Fibon
    {

        // create a method that will print first declared fibonnaci numbers
        static void Main(string[] args)
        {
            Fibonnaci1(5);

            Console.WriteLine();

            Fibonnaci2(7);
            Console.ReadLine();
        }

        public static void Fibonnaci1(int num) // in the parameters we will put the number that we want to print
        {

            int a = 0;
            int b = 1;
            int c;

            Console.Write(a + " " + b + " ");

            for (int i = 2; i < num; i++)
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;

            }
        
        }


        public static void Fibonnaci2(int num)
        {
            int a = 0;
            int b = 1;
            int c; 

            for (int i = 0; i < num; i++)
            {

                c = a + b;
                Console.Write(a + " ");
                a = b;
                b = c;
            
            }
        }
    }
}
