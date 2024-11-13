using System;

class Program {
    static void Main(string[] args) {
        //Define Two Numbers
        int numOne = 12932;
        int numTwo = 2828472;

        // Use built-in methods and save to variable 
        double numberOneSqrt = Math.Floor(Math.Sqrt(Math.Abs(numOne)));

        // Use built-in methods and save to variable 
        double numberTwoSqrt = Math.Floor(Math.Sqrt(Math.Abs(numTwo)));

        //Print
        Console.WriteLine(Math.Min(numberOneSqrt, numberTwoSqrt));
    }
}

