using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithArraysSolo
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a random generator
            Random rnd = new Random();
            //create a 10 element array of doubles
            double[] nums = new double[10];
            //loop through the length of the array
            for (int i=0; i < nums.Length; i++)
            {
                //create a random number with a decimal or floating point numbers
                double num = rnd.NextDouble();
                //round to 2 decimal places
                num = Math.Round(num, 3);
                //put the rounded number into the array
                nums[i] = num;
                //write the position and the number to the console
                Console.WriteLine(i.ToString() + ". " + nums[i]);
            }
            //wait
            Console.WriteLine("Press any key to continue.....");
            Console.ReadLine();
        }
    }
}
