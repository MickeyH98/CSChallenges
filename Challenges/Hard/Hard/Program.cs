using System;
using System.Linq;

namespace Hard
{
    class Program
    {
        static void Main()
        {
			Console.BackgroundColor = ConsoleColor.Yellow;
			Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("The illuminati is real");
			Console.Write(Environment.NewLine);


			int row = 5;
			int space;
			space = row;
            Console.WriteLine("     .     "); //top of pyramid
            for (int j = 1; j <= row; j++)
			{
                //loop for spaces
				for (int i = 1; i < space; i++)
					Console.Write(" ");
                
                space--; //decrease each loop for stair effect

                //loop for stars
				for (int i = 1; i <= 2 * j - 1; i++)
					Console.Write("*");

                //Conditionals for 3D Effect
                switch (j)
                {
                    case 1:
                        Console.Write(@" \    ");
                        break;
                    case 2:
                        Console.Write(@"  \  ");
                        break;
                    case 3:
                        Console.Write(@"   \");
                        break;
                    case 4:
                        Console.Write(@"  /");
                        break;
                    case 5:
                        Console.Write(@"/ ");
                        break;
                }

                Console.Write("\n"); //give pyramid height
			}
        }
    }
}

//HARD: Print a Pyramid

//    *
//   ***
//  *****
// *******
//*********

//Hints: You can use three loops. The big one contains two smaller loops.
//The first inner loops takes care of the # of spaces. The second inner loop handles the # of stars. 

//     . 
//    * \
//   ***  \
//  *****   \ 
// *******  / 
//*********/