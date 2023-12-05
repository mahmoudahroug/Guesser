using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guesser
{
    class Program
    {
        static void Main(string[] args)
        {
                colorText("Guesser V. 1.0.1 Created by Mahmoud", ConsoleColor.Green);

                greetings();

                Console.WriteLine("guess the next number in the sequence");

                int answer = orderGen();
                int guess = 1;

                while (true)
                {
                    string input = Console.ReadLine();
                    if (!Int32.TryParse(input, out guess))
                    {
                        colorText("Invalid number, try again!", ConsoleColor.Red);
                        continue;
                    }
                    guess = Int32.Parse(input);
                    if (guess == answer)
                    {
                        break;
                    }
                    else
                    {
                        colorText("Wrong answer!", ConsoleColor.Red);
                    }
                }
                colorText("You are CORRECT!!!!", ConsoleColor.Cyan);
                Console.ReadLine();
        }
        static void colorText(string phrase, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(phrase);
            Console.ResetColor();
        }
        static void greetings()
        {
            Console.Write("Insert name here: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name + "\nLet's play a game");
        }
        static int orderGen()
        {
            Random x = new Random();
            Random r = new Random();
            char[] op = { '*', '+'};

            int xNum = x.Next(2, 10);
            int yNum = x.Next(2, 10);
            int rNum = r.Next(0, 2);

            switch(op[rNum])
            {
                case '+':
                    Console.Write(xNum + ",");
                    for(int i = 0; i < 2; i++)
                    {
                        xNum += yNum;
                        Console.Write(xNum + ",");
                    }
                    xNum += yNum;
                    break;
                case '*':
                    Console.Write(xNum + ",");
                    for (int i = 0; i < 2; i++)
                    {
                        xNum *= yNum;
                        Console.Write(xNum + ",");
                    }
                    xNum *= yNum;
                    break;
               /* case '/':
                    Console.Write(xNum + ",");
                    for (int i = 0; i < 2; i++)
                    {
                        xNum /= yNum;
                        Console.Write(xNum + ",");
                    }
                    xNum /= yNum;
                    break;
                case '^':
                    Console.Write(xNum + ",");
                    for (int i = 0; i < 2; i++)
                    {
                        xNum = Math.Pow(xNum, yNum);
                        Console.Write(xNum + ",");
                    }
                    xNum = Math.Pow(xNum, yNum);
                    break;
                case '-':
                    Console.Write(xNum + ",");
                    for (int i = 0; i < 2; i++)
                    {
                        xNum -= yNum;
                        Console.Write(xNum + ",");
                    }
                    xNum -= yNum;
                    break;*/
                default:
                    Console.WriteLine("not yet");
                    break;
               
            }
            return xNum;
        }
    }
}
