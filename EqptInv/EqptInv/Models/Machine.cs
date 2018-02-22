﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EqptInv.Models
{
    public class Machine
    {
        public int Id { get; set; }
        public int Num { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Hours { get; set; }
    }
}