namespace EqptInv.Migrations
{
    using EqptInv.Models;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MachineContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MachineContext context)
        {
            context.Machines.AddOrUpdate(
                m => m.Id,
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" },
                new Machine { Num = "900", Make = "CAT", Model = "D8", Hours = "1000" }
                );




        }
    }
}
