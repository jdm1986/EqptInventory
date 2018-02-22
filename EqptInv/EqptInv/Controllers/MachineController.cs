using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EqptInv.Models;


namespace EqptInv.Controllers
{
    public class MachineController : Controller
    {
        // GET: Machine
        public ActionResult Index()
        {
            var machineList = new MachineListViewModel
            {
                Machines = new List<MachineViewModel>
                    {
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                        new MachineViewModel { Id = 1, Num = 900, Make = "CAT", Model = "D8", Hours = 1000},
                    }
            };

            machineList.MachineCounter = machineList.Machines.Count;

            return View(machineList);
        }
    }
}