using ATMAPP.UI;
using System;

namespace ATMAPP
{
    class ATMapp
    {
        static void Main(string[] args)
        {
            AppScreen.Welcome();
            long CardNumner = Validator.Convert<long>("Your Card Numner");
            Console.WriteLine($"Your Card Numner is {CardNumner}");

            Utility.PressEnterToContinue();
        }
    }
}