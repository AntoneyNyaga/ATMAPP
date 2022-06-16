using System;
using System.Collections.Generic;
using System.Text;

namespace ATMAPP.UI
{
    public static class AppScreen
    {
        internal static void Welcome()
        {
            //clears the console window
            Console.Clear();
            // sets the Title of the winddow
            Console.Title = "My ATM APP";
            // sets the foreground color
            Console.ForegroundColor = ConsoleColor.White;

            // setS the welcome message
            Console.WriteLine("\n\n ------Welcome to my ATM APP-------\n");
            //prompts the user to insert thier Atm card
            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Note: Actual macine will accept a physical ATM card, " +
                "read the Account number and validate it.");
            Utility.PressEnterToContinue();
        }

        
    }
}
