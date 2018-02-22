using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EqptInv.Models
{
    public class MachineViewModel
    {
        public int? Id { get; set; }

        [DisplayName("Machine Number")]
        public string Num { get; set; }

        [DisplayName("Make")]
        public string Make { get; set; }

        [DisplayName("Model")]
        public string Model { get; set; }

        [DisplayName("Hour Meter")]
        public string Hours { get; set; }

        public string MachineName => Make + " " + Model + " #" + Num.ToString();

    }   
}