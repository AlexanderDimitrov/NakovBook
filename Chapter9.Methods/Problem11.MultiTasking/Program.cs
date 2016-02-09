using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem11.MultiTasking
{
    /// <summary>
    /// Write a program that solves the following tasks
    /// Put the digits from an integer number into a reversed order.
    /// Calculate the avarage of given sequence of numbers.
    /// Solve the linear equation a * x + b = 0;
    /// </summary>
    class Program
    {
        static void ReverceOrderer(int number)
        {
            if (number == 0)
            {
                throw new ArgumentOutOfRangeException("The Row must not be empty");
            }
            string myString = number.ToString();
           
            for (int i = myString.Length; i > 0; i--)
            {
                Console.Write(myString[i-1]);
            }
            Console.WriteLine();
           
        }

        static void AvarageOfNumbersFinder(int counter)
        {
            int result = 0;
            int currNumber = 0;
            for (int i = 0; i < counter; i++)
            {
                currNumber = int.Parse(Console.ReadLine());
                result += currNumber;
            }
            Console.Write("Your avarage number is : {0}",result/counter);
            Console.WriteLine();
        }

        static void EquasionCalculator(int a, int b, int x)
        {
            if (a == 0)
            {
                throw new ArgumentOutOfRangeException("'a' must NOT be negative");
            }
            
            int result = a * x + b;
            Console.WriteLine(result);
           
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello User to my first Multitasking Program");
            Console.WriteLine("Please Choose Your Task");
            Console.WriteLine("1.Number Reverser");
            Console.WriteLine("2.Avarage Sum Finder");
            Console.WriteLine("3.Equasion - a * x + b = ");
            try
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("Please input your desired number to be reversed: ");
                        int n = int.Parse(Console.ReadLine());
                        ReverceOrderer(n);
                        break;
                    case "2":
                        Console.Write("Please input the Count of the number you desire to sum: ");
                        int h = int.Parse(Console.ReadLine());
                        AvarageOfNumbersFinder(h);
                        break;
                    case "3":
                        Console.WriteLine("Equasion Solver [a * x + b =]");
                        Console.Write("Enter value for 'a'(positive): ");
                        int a = int.Parse(Console.ReadLine());
                        if (a < 0)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        Console.Write("Enter value for 'b': ");
                        int b = int.Parse(Console.ReadLine());
                        Console.Write("Enter value for 'x': ");
                        int x = int.Parse(Console.ReadLine());
                        EquasionCalculator(a,b,x);
                        
                        break;
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Write down a positive Integer!");
            }
           
            

        }
    }
}
