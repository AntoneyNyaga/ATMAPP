using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ATMAPP.UI
{
    public static void PrintMessage(string msg, bool success = true)
    {
        if (success)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        Console.WriteLine(msg);
        Console.ResetColor();
        PressEnterToContinue();
    }

    public static class Utility
    {
        public static string GetUserInput(string prompt)
        { 
            Console.WriteLine($"Enter {prompt}" );
            return Console.ReadLine();
        }
            public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress Enter to continue...\n");
            Console.ReadLine();
        }
    }
}
