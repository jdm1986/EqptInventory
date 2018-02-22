using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EqptInv.Models
{
    public class MachineViewModel
    {
        public int? Id { get; set; }
        public int? EquipNum { get; set; }
        public string EquipMake { get; set; }
        public string EquipModel { get; set; }
        public int? Hours { get; set; }

    }   
}