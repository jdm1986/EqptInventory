using EqptInv.Models;
using System.Data.Entity;

namespace EqptInv
{

    public class MachineContext : DbContext
    {
        public MachineContext() : base("name=MachineContext") { }

        public virtual DbSet<Machine> Machines { get; set; }
    }
}