﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GeradorDeQrCode.Controllers
{
    public class APIController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
