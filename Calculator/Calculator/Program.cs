using Service;
using System;

namespace ConsoleApp1
{
    public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter num1=");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter num2=");
            int num2 = int.Parse(Console.ReadLine());
           

            Console.WriteLine("Enter operation");
            string operation = Console.ReadLine();

            Calculation calculation = new Calculation();
            calculation.Calculate(num1,num2,operation);

           





        }

        
    }
}
