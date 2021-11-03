using Microsoft.AspNetCore.Mvc;
using MvcBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasics.Controllers
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult CheckFever()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckFever(float temperature)
        {
            string message = "";
            message = CheckFeverUtility.FeverCheck(temperature);
            ViewBag.temp = temperature;
            ViewBag.message = message;
            return View("FeverResult");
        }
    }
}
