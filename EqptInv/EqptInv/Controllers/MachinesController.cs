using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EqptInv.Models;

namespace EqptInv.Controllers
{
    public class MachinesController : Controller
    {
        // GET: Machines
        public ActionResult Index()
        {
            return View();
        }
    }
}