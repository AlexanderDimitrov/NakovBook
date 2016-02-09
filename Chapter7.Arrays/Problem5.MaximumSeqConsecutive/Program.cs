using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem5.MaximumSeqConsecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            string input = Console.ReadLine();
            var numbers = input.Split(' ').Select(Int32.Parse).ToList();
            int nextNumber = 0;


            numbers.Add(nextNumber);
   
            for (int i = 0; i < numbers.Count-1; i++)
            {
                nextNumber = numbers[i+1];
                if(nextNumber == numbers[i] + 1)
                {
                    list.Add(numbers[i]);
                    if(i==numbers.Count-3)
                    {
                        list.Add(nextNumber);
                    }
                }
            }
            list.Sort();
            List<int> distinctList = list.Distinct().ToList();
           
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
