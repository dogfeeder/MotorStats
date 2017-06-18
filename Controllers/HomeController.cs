using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MotorStats.Models;

namespace MotorStats.Controllers
{
    public class HomeController : Controller
    {

        private IHorsepowerKilowattConvertService convertService;

        public HomeController(IHorsepowerKilowattConvertService convertService)
        {
            this.convertService = convertService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost("converthp")]
        public IActionResult ConvertHp(HpKwConvertModel model) 
        {
            float horsepower = float.Parse(model.Horsepower);
            model.Kilowatts = convertService.ConvertToHorsepower(horsepower).ToString();

            return new JsonResult(model);
        }
    }
}
