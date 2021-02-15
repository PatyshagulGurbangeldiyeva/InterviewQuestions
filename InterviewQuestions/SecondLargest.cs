using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    class SecondLargest
    {
        public static void Main(string[] args)
        {

            int[] num = { 1, 6, 9, 5,99, 100,-100, 10000 };
            Second(num);
        }
        public static void Second(int[] num)
        {
            int max = num[0];
            
            int second =num[0];

            for (int i = 1; i < num.Length; i++)
            {
                if (num[i] > max)
                {
                    second = max;
                    max = num[i];
                }
                
            }
            Console.WriteLine("The second Largest number is: " + second);
            Console.ReadLine();
        }

    }
}
