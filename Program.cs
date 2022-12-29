using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace project_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter n1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter n2");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1; i <= n2; i++)
            {
                int count = 0;
                for (int j = 2; j <= 1; j++)
                {
                    if (i % j == 0)
                        count++;
                    break;
                }
                if (count == 0 && i != 1)
                {
                    Console.WriteLine("\n" + i);
                }
            }
            
        }
    }
}
