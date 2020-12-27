using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    class Program
    {
        static void Main(string[] args)
        {
            Freight_ts f_ts = new Freight_ts("MAN", 800, 3000000, 20);
            Passenger_ts p_ts = new Passenger_ts("Ford", 200, 600000, 200, 5);
            f_ts.display();
            Console.WriteLine("------------------------");
            p_ts.display();

            Console.WriteLine("------------------------");

            Person guy = new Person();
            Console.WriteLine("------------------------");
            guy.toBuy(f_ts);
            guy.toDrive(f_ts);
            Console.WriteLine("------------------------");
            guy.toBuy(p_ts);
            guy.toDrive(p_ts);

            Console.WriteLine("------------------------");

            Auto auto = new Auto("Nissan", 130, 200000);
            Auto auto1 = (Auto)auto.DeepClone();
            Auto auto2 = (Auto)auto.ShallowClone();
            Console.WriteLine(auto1.ToString());
            Console.WriteLine(auto2);
        }
    }
}
