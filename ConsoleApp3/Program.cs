using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100; i++) 
            {
                if ((i % 4 == 0) && (i % 7 == 0))
                {
                    Console.WriteLine("Go Cards!");
                }
                else if (i % 4 == 0)
                {
                    Console.WriteLine("Go");
                }
                else if (i % 7 == 0)
                {
                    Console.WriteLine("Cards");
                }
                else Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
