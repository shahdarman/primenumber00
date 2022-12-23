// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello sweety");

            int n, a, m = 0, PrimeIndicator = 0;
           
            Console.Write("Please enter the number:... ");
           
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (a = 2; a <= m; a++)
            {
                if (n % a == 0)
                {
                    Console.Write("The entered number is not  a Prime number .");
                    
                    PrimeIndicator = 1;
                    
                    break;
                }
            }
            if (PrimeIndicator == 0)
               
                
                Console.Write("The entered number is a Prime number . ");
            
            
            Console.WriteLine("Thank You , Have A Nice Day");
        }
    }
}
