using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzNoMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 100;
            int fizz = 0;
            int buzz = 0;
            int fizzbuzz = 0;

            for (int i = 0; i < target; i++)
            {
                if(fizzbuzz == 15)
                {
                    Console.WriteLine("FizzBuzz");
                    fizzbuzz = 1;
                    fizz = 1;
                    buzz = 1;
                    continue;
                }

                if (fizz == 3)
                {
                    Console.WriteLine("Fizz");
                    fizzbuzz++;
                    fizz = 1;
                    buzz++;
                    continue;
                }

                if (buzz == 5)
                {
                    Console.WriteLine("Buzz");
                    fizzbuzz++;
                    fizz++;
                    buzz = 1;
                    continue;
                }

                fizzbuzz++;
                fizz++;
                buzz++;
                Console.WriteLine(i);
                    
            }
            Console.ReadKey();
        }
    }
}

