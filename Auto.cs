using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba12
{
    class Auto : Veh
    {
        protected String brand; //марка
        protected int power; //мощность
        protected int cost;     //стоимость
        public Auto()
        {
            brand = "";
            power = 0;
            cost = 0;
        }

        public Auto(String brand, int power, int cost)
        {
            this.brand = brand;
            this.cost = cost;
            this.power = power;
        }

        public void Drive()
        {
            Console.WriteLine($"Человек едет на {brand}");
        }
        public void Buy()
        {
            Console.WriteLine($"Человек купил {brand}");
        }

        public virtual void display()
        {
            Console.WriteLine($"{brand}, {power} - {cost}p");
        }

        public virtual void read()
        {
            Console.WriteLine("Марка: ");
            brand = Console.ReadLine();
            Console.WriteLine("Мощность: ");
            power = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Стоимость: ");
            cost = Convert.ToInt32(Console.ReadLine());
        }

        public object DeepClone()
        {
            return new Auto(this.brand, this.power, this.cost);
        }
        public object ShallowClone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return brand.ToString();
        }

    }
}
