using System;

namespace Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            
            for (int j = 1; j <= 5; j++){ //height
                Console.Write(Environment.NewLine);
                for (int i = 1; i <= 10; i++)
                { //width
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("*");
					
                }

				if (j == 1 || j == 3 || j == 5)
				{
                    Console.BackgroundColor = ConsoleColor.White;
					Console.ForegroundColor = ConsoleColor.White;
					Console.Write(" -------------------------"); //stripes beside stars
				}
				if (j == 2 || j == 4)
				{
                    Console.BackgroundColor = ConsoleColor.Red;
					Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" -------------------------"); //stripes beside stars
				}


            }
            Console.Write(Environment.NewLine);

            for (int i = 1; i <= 5; i++) //loop for stripes under stars
            {
                if (i == 1 || i == 3 || i == 5){
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("------------------------------------");

				}
				if (i == 2 || i == 4)
				{
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.White;
					Console.WriteLine("------------------------------------");
				}
            }

            Console.Write(Environment.NewLine);
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("God bless America!");
		}
    }
}

//MEDIUM: Write a loop that would print out the following: 

//**********
//**********
//**********
//**********
//**********

//You can only have the ' * ' character once!


//********** --------------------
//********** --------------------
//********** --------------------
//********** --------------------
//********** --------------------
//-------------------------------
//-------------------------------
//-------------------------------
//-------------------------------
//-------------------------------