﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebSiteAngel.Models;

namespace WebSiteAngel.Controllers
{
    public class SecondController : Controller
    {
        public IActionResult Index()
        {            
            return View();
        }
       
    }
}
