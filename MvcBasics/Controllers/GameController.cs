using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MvcBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Controllers
{
    public class GameController : Controller
    {
        [HttpGet]
        public IActionResult GuessingGame()
        {
            Random random = new Random();

            if (!string.IsNullOrWhiteSpace(random.ToString()))
            {
                HttpContext.Session.SetInt32("Number", random.Next(1, 100));
            }

            CookieOptions option = new CookieOptions();
            option.Expires = DateTime.Now.AddHours(1);
            Response.Cookies.Append("CountGuesses", "0", option);
            return View();
        }
        [HttpPost]
        public IActionResult GuessingGame(int guess)
        {
            string message = "";
            int nrOfGuesses = 0;


            if (guess > 0 || guess <= 100)
            {

                int number = (int)HttpContext.Session.GetInt32("Number");
                string nrOfGuessesStored = Request.Cookies["CountGuesses"];
                nrOfGuesses = Int32.Parse(nrOfGuessesStored) + 1;
                message = Game.GuessNumber(guess, number);
            }

            else
            {
                message = "You must enter a number beween 1-100!";
            }

            if (!string.IsNullOrWhiteSpace(nrOfGuesses.ToString()))
            {
                CookieOptions option = new CookieOptions();
                option.Expires = DateTime.Now.AddMinutes(10);
                Response.Cookies.Append("CountGuesses", nrOfGuesses.ToString(), option);
            }

            
            ViewBag.guess = guess;
            ViewBag.nrOfGuesses = nrOfGuesses;
            ViewBag.msg = message;

            if (message.Contains("correct"))
            {
                return View("WinMessage");
            }

            else
            {
                return View();
            }

        }
    }
}
