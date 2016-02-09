using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5.FibonaciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counterForTheLoop = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 1;
            int virtualNumber = 0;
            int result = 0;
            Console.Write("0 1 ");
            for (int i = 0; i < counterForTheLoop; i++)
            {

                result = firstNumber + secondNumber;
                virtualNumber = secondNumber;
                secondNumber = result;
                firstNumber = virtualNumber;
                Console.Write(result + " ");
             

            }
            
        }
    }
}
