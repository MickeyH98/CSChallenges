using System;

namespace VeryHard
{
    class Program
    {
        static void Main(string[] args)
        {
            double userInput;
            string conversion;
            double output;
            bool repeat = true;

            while(repeat){
				Console.WriteLine("-Unit Converter-");
				Console.WriteLine("Please enter a value :-)");
				userInput = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Thanks! What would you like to convert " + userInput + " into?");
                Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("I -> convert from inches to centimeters.");
                Console.ForegroundColor = ConsoleColor.Blue;
				Console.WriteLine("G -> convert from gallons to liters.");
                Console.ForegroundColor = ConsoleColor.Yellow;
				Console.WriteLine("M -> convert from mile to kilometer.");
                Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("P -> convert from pound to kilogram.");
                Console.ForegroundColor = ConsoleColor.White;
				conversion = Console.ReadLine();
				switch (conversion)
				{
					default:
						Console.WriteLine("Please enter a valid letter");
						break;
					case "I": // inches -> centimeters
						output = userInput * 2.54;
                        Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine(userInput + " Inches = " + output + " Centimeters");
                        Console.ForegroundColor = ConsoleColor.White;
						break;
					case "G": // gallons -> liters
						output = userInput * 3.78541;
                        Console.ForegroundColor = ConsoleColor.Blue;
						Console.WriteLine(userInput + " Gallons = " + output + " Liters");
                        Console.ForegroundColor = ConsoleColor.White;
						break;
					case "M": // miles -> kilometers
						output = userInput * 1.60934;
                        Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine(userInput + " Miles = " + output + " Kilometers");
                        Console.ForegroundColor = ConsoleColor.White;
						break;
					case "P": // pounds -> kilograms
						output = userInput * 0.453592;
                        Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine(userInput + " Pounds = " + output + " Kilograms");
                        Console.ForegroundColor = ConsoleColor.White;
						break;
				}
				Console.WriteLine("Try again? Y / N");
				string againInput;
				againInput = Console.ReadLine();

				if (againInput == "N")
				{
					repeat = false;
				}
				else if (againInput == "Y")
				{
					continue;
				}
            }
        }
    }
}

//VERY HARD:  
//Write a program using a switch statement that takes one value from the user 
//and asks about the type of conversion and then performs a conversion depending on the type of conversion.
//If user enters: 
//I -> convert from inches to centimeters.
//G -> convert from gallons to liters.
//M -> convert from mile to kilometer.
//P -> convert from pound to kilogram.
//If the user enters any other character then show a proper message.