using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.GetMaxMethod
{
    /// <summary>
    /// Create a method GetMax() with two integet parameters
    /// return maximal of the two numbers + test program ofc
    /// </summary>
    class Program
    {
        public static void GetMax(double firstNumber ,double secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                Console.WriteLine("This Number is Bigger {0} than {1}",firstNumber,secondNumber);
            }

            if (secondNumber > firstNumber)
            {
                Console.WriteLine("This Number is Bigger {0} than {1}", firstNumber, secondNumber);
            }
            
        }

        static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            GetMax(firstNumber,secondNumber);

        }
    }
}
