using AspNetCoreNthPrimeNumber.Web.Code;
using AspNetCoreNthPrimeNumber.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreNthPrimeNumber.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? nth)
        {
            var model = new HomeModel();
            model.Nth = nth;

            if (nth.HasValue)
            {
                model.NthPrime = NthPrime.Calculate(nth.Value);
            }

            return View(model);
        }
    }
}
