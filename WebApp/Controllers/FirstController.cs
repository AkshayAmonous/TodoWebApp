﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public string Index()
        {
            return "Hello Akshay";
        }
        public string GetString()
        {
            return "Build Successful";
        }
        public string GetCustomer()
        {
            return "Akshay Ghanvata";        }
    }
}