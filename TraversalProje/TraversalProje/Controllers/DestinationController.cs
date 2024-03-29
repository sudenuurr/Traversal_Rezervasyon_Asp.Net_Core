﻿using BussinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalProje.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager dm = new DestinationManager(new EfDestinationDal());
        public IActionResult Index()
        {
            var values = dm.TGetList();
            return View(values);
        }  
        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            ViewBag.i = id;
            var values = dm.TGetByID(id);
            return View(values);
        }    
        [HttpPost]
        public IActionResult DestinationDetails(Destination p)
        { 
            return View();
        }
    }
}
