using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
           // random.Next(0, 2);
            int myRandom = random.Next(0, 2);

            if (myRandom == 0)
            {
                Console.WriteLine("0");
            }
            else if  (myRandom == 1)
            {
                Console.WriteLine("1");
            }
            else 
            {
                Console.WriteLine("2");
            }
            Console.ReadLine();

        }
    }
}
