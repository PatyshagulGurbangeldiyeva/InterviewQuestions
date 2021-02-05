using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterviewQuestions
{
    class ArrayDublicates
    {

        // create an array and return boolean if the array has dublicates or not
        public static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 5, 7, 8 };
            Console.WriteLine("Let's see does the first array has dublicates");
            Console.Write(ArrayDub(nums1));

            Console.WriteLine();

            int[] nums2 = { 1, 2, 4, 7 };
            Console.WriteLine("Let's see does the second array has dublicates");
            Console.Write(ArrayDub(nums2));

            Console.ReadLine();

        }


        public static bool ArrayDub(int[] nums)
        {
            bool dublicate = true;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j] && i != j)
                    {
                        dublicate = false;
                        
                    }
                
                }
                    
            
            }
            return dublicate;
        }
        
    }
}
