﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_ECD_Start.Controllers
{
    public class Chart : Controller
    {
        public IActionResult Charts()
        {
            return View();
        }
    }
}
