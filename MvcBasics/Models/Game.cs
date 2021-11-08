using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Models
{
    public class Game
    {
        public static string GuessNumber(int guess, int number)
        {


            if (guess > number)
            {
                return $"Nr {guess} is too high, please try again!";
            }

            if (guess < number)
            {
                return $"Nr {guess} is too low, please try again!";
            }

           
            return "correct";
        }


    }
}
