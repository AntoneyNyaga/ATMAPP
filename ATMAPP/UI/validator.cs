using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ATMAPP.UI
{
    public static class Validator
    {
        public static T Convert <T>(string prompt)
        {
          bool valid = false;
          string userInput;
        while (!valid)
            {
                userInput = Utility.GetUserInput(prompt);

                try
                {
                    var Convertor = TypeDescriptor.GetConverter(typeof(T));
                    if (Convertor != null)
                    {
                        return (T)Convertor.ConvertFromString(userInput);
                    }
                    else
                    {
                        return default;
                    }
                }
                catch
                {
                    Console.WriteLine("Invalid input, Please Try Again");
                }
            }
            return default;

        }
    }
}
