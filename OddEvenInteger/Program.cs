using System;
using System.Dynamic;

namespace OddEvenInteger {
    class Program {
        static void Main(string[] args) {

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Welcome to the Odd/Even Integer Verification Machine");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please enter an Integer");
            var num1AsStr = Console.ReadLine();
            var num1 = Convert.ToInt32(num1AsStr);
            var answer = num1 % 2;
            if (answer == 0) {
                Console.WriteLine($"{num1AsStr} is an Even Number");
            } else {
                Console.WriteLine($"{num1AsStr} is an Odd Number");
            }
            Console.WriteLine("Thanks for using the Odd/Even Integer Verification Machine! Have a Nice Day!");

            /*
            var total = 0;
            for (var idx = 0; idx <= 25; idx++) {
                total += idx; //total = toal + idx
            }                                           for loop practice
            Console.WriteLine($"The sum of all numbers between 1 and 24 is {total}");
            */
            }
        }
    }
}
