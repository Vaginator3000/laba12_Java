using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    class Freight_ts : Auto
    {
        int lifting_capacity;

        public Freight_ts() : base()
        {
            lifting_capacity = 0;
        }

        public Freight_ts(String brand, int power, int cost, int lift_cap) : base(brand, power, cost)
        {
            lifting_capacity = lift_cap;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Грузоподъемность: {lifting_capacity}т");
        }

        public override void read()
        {
            base.read();
            Console.WriteLine("Грузоподъемность: ");
            lifting_capacity = Convert.ToInt32(Console.ReadLine());
        }
    }
}
