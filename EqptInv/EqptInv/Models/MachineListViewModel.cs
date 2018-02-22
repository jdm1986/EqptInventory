using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EqptInv.Models
{
    public class MachineListViewModel
    {
        public List<MachineViewModel> Machines { get; set; }
        public int MachineCounter { get; set; }
    }
}