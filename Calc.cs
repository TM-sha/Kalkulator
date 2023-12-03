using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    internal class Calc
    {       
        public static void Calculator()
        {
            var isTrue = true;

            do
            {
                Console.WriteLine();
                Console.Write("Enter a number -> ");
                int userNum = Convert.ToInt32(Console.ReadLine());


                Console.Write("Enter an operator -> (+, -, *, /) ");
                string userOperator = Console.ReadLine();


                Console.Write("Enter another number -> ");
                double userNum2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();


                if (userOperator == "+")
                {
                    Console.Write($"{userNum} + {userNum2} = ");
                    Console.WriteLine(userNum + userNum2);
                }
                else if (userOperator == "-")
                {
                    Console.Write($"{userNum} - {userNum2} = ");
                    Console.WriteLine(userNum - userNum2);
                }
                else if (userOperator == "*")
                {
                    Console.Write($"{userNum} * {userNum2} = ");
                    Console.WriteLine(userNum * userNum2);
                }
                else if (userOperator == "/")
                {
                    Console.Write($"{userNum} / {userNum2} = ");
                    Console.WriteLine(userNum / userNum2);
                }
                else
                {
                    Console.WriteLine("Invalid opperator, try again..");
                }
            } while (isTrue);
        }
    }
}
