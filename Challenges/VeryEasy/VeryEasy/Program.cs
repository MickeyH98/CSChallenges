using System;
using System.Diagnostics;


namespace VeryEasy
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Hello World");

			//Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Red;

            Console.Write(" _   _ ");//h1
            Console.Write(" ______");//e1
            Console.Write(" ___    ");//l1
            Console.Write(" ___    ");//l1
            Console.Write(" _____ ");//o1
            Console.Write(" _     _ ");//w1
            Console.Write(" _____ ");//o1
            Console.Write(" _____   ");//r1
            Console.Write(" ___    ");//l1
            Console.Write(" _____  ");//d1

			Console.Write(Environment.NewLine);
			Console.ForegroundColor = ConsoleColor.Yellow;

			Console.Write("| | | |");//h2
            Console.Write("|     |");//e2
            Console.Write("|  |    ");//l2
			Console.Write("|  |    ");//l2
			Console.Write("|     |");//o2
			Console.Write("| | _ | |");//w2
			Console.Write("|     |");//o2
			Console.Write("|   _ |  ");//r2
			Console.Write("|  |    ");//l2
			Console.Write("|     | ");//d2

			Console.Write(Environment.NewLine);
			Console.ForegroundColor = ConsoleColor.Green;

			Console.Write("| |_| |");//h3
			Console.Write("|  ___|");//e3
			Console.Write("|  |    ");//l3
			Console.Write("|  |    ");//l3
			Console.Write("|  _  |");//o3
			Console.Write("| || || |");//w3
			Console.Write("|  _  |");//o3
			Console.Write("|  | ||  ");//r3
			Console.Write("|  |    ");//l3
			Console.Write("|  _   |");//d3

			Console.Write(Environment.NewLine);
			Console.ForegroundColor = ConsoleColor.Blue;

			Console.Write("|     |");//h4
			Console.Write("| |___ ");//e4
			Console.Write("|  |    ");//l4
			Console.Write("|  |    ");//l4
			Console.Write("| | | |");//o4
			Console.Write("|       |");//w4
			Console.Write("| | | |");//o4
			Console.Write("|  |_||_ ");//r4
			Console.Write("|  |    ");//l4
			Console.Write("| | |  |");//d4

			Console.Write(Environment.NewLine);
			Console.ForegroundColor = ConsoleColor.Magenta;

			Console.Write("|     |");//h5
			Console.Write("|  ___|");//e5
			Console.Write("|  |___ ");//l5
			Console.Write("|  |___ ");//l5
			Console.Write("| |_| |");//o5
			Console.Write("|       |");//w5
			Console.Write("| |_| |");//o5
			Console.Write("|   __  |");//r5
			Console.Write("|  |___ ");//l5
			Console.Write("| |_|  |");//d5

			Console.Write(Environment.NewLine);
			Console.ForegroundColor = ConsoleColor.Cyan;

			Console.Write("|  _  |");//h6
			Console.Write("| |___ ");//e6
			Console.Write("|      |");//l6
			Console.Write("|      |");//l6
			Console.Write("|     |");//o6
			Console.Write("|   _   |");//w6
			Console.Write("|     |");//o6
			Console.Write("|  |  | |");//r6
			Console.Write("|      |");//l6
			Console.Write("|      |");//d6

			Console.Write(Environment.NewLine);
			Console.ForegroundColor = ConsoleColor.White;

			Console.Write("|_| |_|");//h7
            Console.Write("|_____|");//e7
            Console.Write("|______|");//l7
			Console.Write("|______|");//l7
			Console.Write("|_____|");//o7
			Console.Write("|__| |__|");//w7
			Console.Write("|_____|");//o7
			Console.Write("|__|  |_|");//r7
			Console.Write("|______|");//l7
			Console.Write("|_____| ");//d7
		}
    }
}


//VERY EASY:  Create a basic C# console-mode program that simply outputs the text "Hello World".  
//Your program should wait for the user to press a key before the program exits.