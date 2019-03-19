using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = 'Q';
            bool keepRunning = true;

            do
            {
                Console.WriteLine();
                Console.Write("请选择计算操作： (加法-Add, 减法-Subtract, 乘法-Multiply, 除法-Divide, 退出-Quit): ");
                string input = Console.ReadLine();
                firstChar = input[0];

                // this is used in both the if statement and the do/while loop
                keepRunning = !(firstChar == 'q' || firstChar == 'Q');

                double firstNumber = 0;
                double secondNumber = 0;

                if (keepRunning)
                {
                    Console.Write("第一个操作数为: ");
                    string firstNumberInput = Console.ReadLine();
                    firstNumber = double.Parse(firstNumberInput);

                    Console.Write("第二个操作数为: ");
                    string secondNumberInput = Console.ReadLine();
                    secondNumber = double.Parse(secondNumberInput);
                }

                double result = 0;
                switch (firstChar)
                {
                    case 'a':
                    case 'A':
                        result = firstNumber + secondNumber;
                        break;
                    case 's':
                    case 'S':
                        result = firstNumber - +secondNumber;
                        break;
                    case 'm':
                    case 'M':
                        result = firstNumber * secondNumber;
                        break;
                    case 'd':
                    case 'D':
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        result = -1;
                        break;
                }

                Console.WriteLine();
                Console.WriteLine("计算结果为 " + result);

                //StringBuilder sb = new StringBuilder();
                //sb.Append("计算结果为 ");
                //sb.Append(result.ToString());
                //Console.WriteLine(sb.ToString());
            } while (keepRunning);
        }
    }
}
