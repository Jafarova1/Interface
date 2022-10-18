using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class Calculation : ICalculation
    {

        public  void Calculate(int num1, int num2, string operation)
        {
            {

                switch (operation)
                {
                    case "+":
                        {
                            int result1 = num1 + num2;
                            Console.WriteLine(result1);
                            break;
                        }
                    case "-":
                        {
                            int result2 = num1 - num2;
                            Console.WriteLine(result2);
                            break;
                        }
                    case "*":
                        {
                            int result3 = num1 * num2;
                            Console.WriteLine(result3);
                            break;
                        }
                    case "/":
                        {
                            int result4 = num1 / num2;
                            Console.WriteLine(result4);
                            break;
                        }

                    default:
                        Console.WriteLine("Enter correct operation");
                        break;

                }
            }
        }

        public void Calculate()
        {
            Console.WriteLine();

        }
    }
}


