using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlocProjectCamp.Controllers
{
    public class Categoy : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
