using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.For_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is the for Loop");

            for(int i=0; i<=5; i++) 
            { 
                Console.WriteLine(i);
            }

            Console.WriteLine("This is the WHILE Loop");
            int j = 0;

            while (j <= 5) 
            {
                Console.WriteLine(j);
                j++;
            }
        }
    }
}
