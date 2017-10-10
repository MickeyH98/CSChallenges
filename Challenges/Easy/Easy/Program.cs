using System;

namespace Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while(repeat){
				Console.WriteLine("Please enter an integer.");
				int userInput;
				try
				{
					userInput = Convert.ToInt32(Console.ReadLine());
					if (userInput < 10)
					{
						Console.WriteLine("This number is too small.");
					}
					else if (userInput >= 10)
					{
						Console.WriteLine("This number is big enough.");
					}
				}
				catch (Exception)
				{
					Console.WriteLine("Please enter a valid number.");
				}

				Console.WriteLine("Try again? Y / N");
				string againInput;
				againInput = Console.ReadLine();

				if (againInput == "N")
				{
                    repeat = false;
                }
                else if(againInput == "Y")
                {
                    continue;
                }
			}
		}
    }
}


//EASY: Create a program that asks the user to enter an integer.
//If the integer is less than 10, print the message "This number is too small". 
//If the integer is greater than or equal to 10, print "This number is big enough".  
//Hint: read a line and then use Int32.TryParse() to convert the text to an integer. 