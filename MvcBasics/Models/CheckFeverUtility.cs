using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Models
{
    public class CheckFeverUtility
    {
        public static string FeverCheck(float temperature)
        {
            string message = "";
            if (temperature >= 38)
            {
                message = "You have a fever";
            }

            else
            {
                message = "You don't have a fever";
            }

            return message;
        }
    }
}
