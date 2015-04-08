using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                Console.WriteLine(FizzBuzz(i));   
            }
            Console.ReadKey();
        }
        public static string FizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "fizzbuzz";
            }
            else if (number % 5 == 0)
            {
                return "buzz";
            }
            else if (number % 3 == 0)
            {
                return "fizz";
            }
            else
            {
                string numString = number.ToString();
                return numString;
            }


        }   
    }
}
