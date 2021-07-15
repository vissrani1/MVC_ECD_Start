using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace MVC_ECD_Start.Controllers
{
    public class AboutUs : Controller
    {
        public IActionResult About()
        {
            return View();
        }
    }
}
