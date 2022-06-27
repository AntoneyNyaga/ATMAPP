using System;
using System.Collections.Generic;
using System.Text;

namespace ATMAPP.UI
{
    public static class Validator
    {
        public static object TypeDescriptor { get; private set; }

        public static T Convert<T>(string prompt)
        {
          bool valid = false;
        String userInput;
        while (!valid)
            {
                userInput = Utility.GetUserInput(prompt);

                try
                {
                    var Convertor = TypeDescriptor.GetConvertor(typeof(T));
                    if (Convertor! = null)

                }
            }

        }
    }
}
