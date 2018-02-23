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
       
        public ActionResult Index()
        {
            using (var machineContext = new MachineContext())
            {
                {
                    var machineList = new MachineListViewModel
                    {

                        Machines = machineContext.Machines.Select(m => new MachineViewModel
                        {
                            Num = m.Num,
                            Make = m.Make,
                            Model = m.Model,
                            Hours = m.Hours
                        }).ToList()

                    };

                    machineList.MachineCounter = machineList.Machines.Count;

                    return View(machineList);


                    }
                }

        }

        public ActionResult MachineDetail(int id)
        {
            var machine = Machines.SingleOrDefault(p => p.Id == id);
            if (machine != null)
            {
                var machineViewModel = new MachineViewModel
                {
                    Id = machine.Id,
                    Num = machine.Num,
                    Make = machine.Make,
                    Model = machine.Model,
                    Hours = machine.Hours,
                };

                return View(machineViewModel);
            }

            return new HttpNotFoundResult();

        }

        public ActionResult MachineAdd()
        {
            var machineViewModel = new MachineViewModel();

            return View("AddEditMachine", machineViewModel);
        }

        [HttpPost]
        public ActionResult AddMachine(MachineViewModel machineViewModel)
        {
            var nextId = Machines.Max(p => p.Id) + 1;

            var machine = new Machine
            {
                Id = nextId,
                Num = machineViewModel.Num,
                Make = machineViewModel.Make,
                Model = machineViewModel.Model,
                Hours = machineViewModel.Hours
            };

            Machines.Add(machine);

            return RedirectToAction("Index");
        }

        public ActionResult MachineEdit(int id)
        {
            var machine = Machines.SingleOrDefault(p => p.Id == id);

            if (machine != null)
            {
                var machineViewModel = new MachineViewModel
                {
                    Id = machine.Id,
                    Num = machine.Num,
                    Make = machine.Make,
                    Model = machine.Model,
                    Hours = machine.Hours,
                };

                return View("AddEditMachine", machineViewModel);
            }

            return new HttpNotFoundResult();
        }

        [HttpPost]
        public ActionResult EditMachine(MachineViewModel machineViewModel)
        {
            var machine = Machines.SingleOrDefault(p => p.Id == machineViewModel.Id);

            if (machine != null)
            {
                machine.Num = machineViewModel.Num;
                machine.Make = machineViewModel.Make;
                machine.Model = machineViewModel.Model;
                machine.Hours = machineViewModel.Hours;

                return RedirectToAction("Index");
            }

            return new HttpNotFoundResult();

        }

        [HttpPost]
        public ActionResult DeleteMachine(MachineViewModel machineViewModel)
        {
            var machine = Machines.SingleOrDefault(p => p.Id == machineViewModel.Id);

            if (machine != null)
            {
                Machines.Remove(machine);

                return RedirectToAction("Index");

            }

            return new HttpNotFoundResult();
        }
    }

        
}