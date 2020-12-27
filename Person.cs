using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("Появился человек");
        }
        public void toDrive(Veh veh)
        {
            veh.Drive();
        }
        public void toBuy(Veh veh)
        {
            veh.Buy();
        }
    }
}
