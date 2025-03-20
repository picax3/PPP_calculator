using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Consoleui userinterface = new Consoleui();
            userinterface.DisplayOperations();
            Console.WriteLine("Testing");
            Console.ReadLine();
        }
    }
}
