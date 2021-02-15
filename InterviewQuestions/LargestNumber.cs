using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class LargestNumber
    {

        public static void Main(string[] args)
        {
            int[] num = { 1, 4, 8, 0, 33, 67 };
            Largest(num);
            Console.ReadLine();
        
        }


        public static void Largest(int[] num)
        {
            int largest =0;

            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] > largest)
                {
                    largest = num[i];
                }

               
            }
            Console.WriteLine(largest);
        }


    }
}
