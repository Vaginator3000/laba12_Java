using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    class Passenger_ts : Auto
    {
        int num_of_seats;
        int max_speed;

        public Passenger_ts() : base() 
        {
            max_speed = 0;
            num_of_seats = 0;
        }

        public Passenger_ts(String brand, int power, int cost, int mspeed, int nseats) : base(brand,power,cost) 
        {
            max_speed = mspeed;
            num_of_seats = nseats;
        }

        public override void display()
        {
            base.display();
            Console.WriteLine($"Макс. скорость: {max_speed}км/ч\nЧисло посадочных мест: {num_of_seats}");
        }

        public override void read()
        {
            try
            {
                base.read();
                Console.WriteLine("Макс. скорость: ");
                max_speed = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Число посадочных мест: ");
                num_of_seats = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}
