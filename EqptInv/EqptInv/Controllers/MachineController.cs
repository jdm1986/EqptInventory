using System.Linq;
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
            using (var machineContext = new MachineContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(p => p.Id == id);
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
            using (var machineContext = new MachineContext())
            {
                var machine = new Machine
                {
                    Num = machineViewModel.Num,
                    Make = machineViewModel.Make,
                    Model = machineViewModel.Model,
                    Hours = machineViewModel.Hours
                };

                machineContext.Machines.Add(machine);
                machineContext.SaveChanges();

            }
                

            return RedirectToAction("Index");

        }

        public ActionResult MachineEdit(int id)
        {
            using (var machineContext = new MachineContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(p => p.Id == id);
                if (machine != null)
                {
                    var machineViewModel = new MachineViewModel
                    {
                        Num = machine.Num,
                        Make = machine.Make,
                        Model = machine.Model,
                        Hours = machine.Hours,
                    };

                    return View("AddEditMachine", machineViewModel);
                }
            }

            return new HttpNotFoundResult();
        }

        [HttpPost]
        public ActionResult EditMachine(MachineViewModel machineViewModel)
        {
            using (var machineContext = new MachineContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(p => p.Id == machineViewModel.Id);

                if (machine != null)
                {
                    machine.Num = machineViewModel.Num;
                    machine.Make = machineViewModel.Make;
                    machine.Model = machineViewModel.Model;
                    machine.Hours = machineViewModel.Hours;

                    return RedirectToAction("Index");
                }
            }
                

            return new HttpNotFoundResult();

        }

        [HttpPost]
        public ActionResult DeleteMachine(MachineViewModel machineViewModel)
        {
            using (var machineContext = new MachineContext())
            {
                var machine = machineContext.Machines.SingleOrDefault(p => p.Id == machineViewModel.Id);

                if (machine != null)
                {
                    machineContext.Machines.Remove(machine);
                    machineContext.SaveChanges();

                    return RedirectToAction("Index");

                }
            }

            return new HttpNotFoundResult();
        }
    }

        
}