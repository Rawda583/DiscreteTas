using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter n1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter n2");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("the perfect numbers are:");

            for(int i = n1; i<= n2; i++)
            {
                int j = 1;
                int sum = 0;
                while(j < i)
                {
                    if(i % j == 0)
                    {
                        sum = sum + j;
                        j++;
                    }
                }
                if(sum == 0)
                {
                    Console.WriteLine("{0}", i);
                }
            }
        }
    }
}
