using ATMAPP.UI;
using System;

namespace ATMAPP
{
    class ATMapp
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            String CardNumner = Utility.GetUserInput("Your Card Numner");
            Console.WriteLine($"Your Card Numner is {CardNumner}");

            Utility.PressEnterToContinue();
        }
    }
}