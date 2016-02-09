using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3.Smallest_Largers_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a count of Numbers for Ze Test :");
            int a = int.Parse(Console.ReadLine());
            int minValue = 0;
            int maxValue = 0;
            for (int i = 0; i < a; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                
                if(numbers > maxValue)
                {
                    maxValue = numbers;
                }
                if(numbers < minValue)
                {
                    minValue = numbers;
                }
                if(i==a-1)
                {
                    Console.WriteLine(maxValue);
                    Console.WriteLine(minValue);
                }
            }
            
        }
    }
}
