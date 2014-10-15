using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * FizzBuzz Fun Mark 1.0, yay!
 * A simple demo of three ways to compute FizzBuzz.
 * Ranging from the obvious solution to some convoluted
 * but fun approaches, because I love looking at 
 * problems from unexpected angles and seeing how things go.
 * 
 * Written in C#, runs from console. 
 */
namespace ConsoleApplication1
{
    class FizzBuzzFun
    {
        static void Main(string[] args)
        {
            double endPoint;
            Console.WriteLine("Enter a number to count to.");
            if (double.TryParse(Console.ReadLine(), out endPoint))
            {
                FizzBuzzer(endPoint);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number above zero.");
            }

            Console.Out.Write("Press any key to end.");
            Console.ReadKey();
        }//end Main

        static void FizzBuzzer(double endPoint)
        {
            double i = 1;

            while (i <= endPoint)
            {
                Console.Write("For " + i + " Nested Says: \t ");
                FBNestedIfs(i);
                Console.Write("For " + i + " String Says: \t ");
                FBString(i);
                Console.Write("For " + i + " Recurse Says: \t ");
                FBRecurse(i);
                i++;
            }

        }

        static void FBNestedIfs(double i)
        {
            double threeCheck = i % 3;
            double fiveCheck = i % 5;

            if (threeCheck + fiveCheck == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else
            {
                if (threeCheck == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {

                    if (fiveCheck == 0)
                    {
                        Console.WriteLine("Buzz");
                    }
                    else
                    {
                        Console.WriteLine(i.ToString());
                    }
                }
            }

        }// close FB1

        static void FBRecurse(double i)
        {
            int flag = 0;
            RecStepThree(i, ref flag);
            RecStepFive(i, ref flag);

            if (flag == 1)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(i);
            }
            
        } // close FBRecurse

        static void RecStepThree(double i, ref int flag)
        {
            if (i < 3)
            {                
                return;
            }
            if (i == 3)
            {
                Console.Write("Fizz..");
                flag = 1;
                return;
            }

            i = i - 3;
            RecStepThree(i, ref flag);

        }// close RecStep

        static void RecStepFive(double i, ref int flag)
        {
            if (i == 5 || i == 0)
            {
                Console.Write("Buzz..");
                flag = 1;
                return;
            }
            if (i < 10 )
            {
                return;
            }
            

            i = i - 5;
            RecStepFive(i, ref flag);

        }// close RecStep
        static void FBString(double i)
        {
            string temp = i.ToString();
            int length = temp.Length;
            char lsd = temp[length-1];
            double total = 0;
           
            double num1 = 11;
            string holder;

            string totalTemp;
            string tempDigit;
            int digit1, digit2;

           /* This loops through the length of the input number, adding 1 digit at a time
            * to the running total stored in total. Each pass total is checked to see if
            * it has reached double digits, and if found to be so the two digits are then
            * extracted and added together, to make sure total is always a single digit
            * number for the next pass of the loop.
            */
                for (int j = 0; j < length; j++)
                {
                    holder = " " + temp[j];
                    if (double.TryParse(holder, out num1))
                    {
                       
                        total = total + num1;

                        if (total > 9)
                        {                            
                            totalTemp = total.ToString();
                            tempDigit = "0" + totalTemp[0]; // padded with "0" so preserve string state
                            digit1 = int.Parse(tempDigit);
                            tempDigit = "0" + totalTemp[1];
                            digit2 = int.Parse(tempDigit);
                            total = digit1 + digit2;
                             
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error while parsing number!");
                        return;
                    }
                }// end for loop

                if ((total == 3 || total == 6 || total == 9) && (lsd == '0' || lsd == '5'))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    if (total == 3 || total == 6 || total == 9)
                    {
                        Console.WriteLine("Fizz.");
                    }
                    else
                    {
                        if (lsd == '0' || lsd == '5')
                        {
                            Console.WriteLine("Buzz.");
                        }
                        else
                        {
                            Console.WriteLine(i.ToString());
                        }

                    }
                }

        }// close FBString
        static void FBSimple(double i)
        {
            bool Flag;

            if (i % 3 == 0)
            {
                Console.Write("Fizz");
                Flag = true;
            }

            if (i % 5 == 0)
            {
                Console.Write("Buzz");
                Flag = true;
            }

            if (Flag == false)
            {
                Console.Write(i);
            }
            Flag = false;
            Console.WriteLine();
        }


    }// close class
}//close namespace