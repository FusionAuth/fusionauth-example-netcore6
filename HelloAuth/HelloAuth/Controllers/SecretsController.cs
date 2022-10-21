﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HelloAuth.Controllers
{
    public class SecretsController : Controller
    {
        [Authorize]
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}

