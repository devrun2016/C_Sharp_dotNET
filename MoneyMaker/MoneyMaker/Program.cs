//Money Maker
using System;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Money Maker");
            //Use Console.WriteLine() and Console.ReadLine() to ask the user for the amount to convert and capture the value in a variable.
            Console.WriteLine("Enter an amount  to convert to coins: ");
            string totalAmount = Console.ReadLine();

            //Convert String to Double
            double convertedAmount = Convert.ToDouble(totalAmount);

            Console.WriteLine($"{totalAmount} cent is qeual to....");
            /*
                 A gold coin is worth 10 cents.
                A silver coin is worth 5 cents.
            */
            int goldValue = 10;
            int silverValue = 5;

            //Using Math.Floor() find gold coins
            double goldCoins = Math.Floor(convertedAmount / goldValue);

            //Find remainder
            double remainder = convertedAmount % goldValue;

            //Find silver coins, and round down
            double silverCoins = Math.Floor(remainder / silverValue);

            //Find remiander for silver coins
            remainder = remainder  % silverValue;

            Console.WriteLine("Gold coins: " + goldCoins);
            Console.WriteLine("Silver coins: " + silverCoins);
            Console.WriteLine("Bronze coins: " + Math.Floor(remainder));
        }
    }
}