using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Models
{
    public class CheckFeverUtility
    {
        public static string FeverCheck(float temperature, string tempType)
        {

            string message = "";

            if (tempType == "Celsius")
            {
                if (temperature >= 38)
                {
                    message = "You have a fever.";
                }

                else if (temperature < 35)
                {
                    message = "You have hypothermia.";
                }

                else
                {
                    message = "You don't have a fever.";
                }

            }

            else if (tempType == "Fahrenheit")
            {
                if(temperature >= 100.4)
                {
                    message = "You have a fever.";
                }

                else if (temperature < 95)
                {
                    message = "You have hypothermia.";
                }

                else
                {
                    message = "You don't have a fever.";
                }
            }


            return message;
        }
    }
}
