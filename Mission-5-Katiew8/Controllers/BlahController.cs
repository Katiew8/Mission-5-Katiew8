﻿using Microsoft.AspNetCore.Mvc;
using Mission_5_Katiew8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission_5_Katiew8.Controllers
{
    public class BlahController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Calc()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calc(CalcModel model)
        {
            return View();
        }


    }
}
