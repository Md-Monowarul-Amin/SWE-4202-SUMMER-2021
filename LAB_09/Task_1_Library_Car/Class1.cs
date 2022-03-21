using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_Library_Car
{
    public class Car
    {
        Seat car_seat;
        Wheel car_wheel;
        Engine car_engine;
        Door car_door;

        public void display()
        {
            this.car_seat.display_seat();
            this.car_door.display_door();
            this.car_wheel.display_wheel();
            this.car_engine.display_Engine();
            Console.WriteLine();
            Console.Read();
        }
        public Car(Seat car_seat, Wheel car_wheel, Engine car_engine, Door car_door)
        {
            this.car_seat = car_seat;
            this.car_wheel = car_wheel;
            this.car_engine = car_engine;
            this.car_door = car_door;
        }
    }

    public class Seat
    {
        string comfortability;
        bool seat_warmer;

        public void set_comfortibility(string comfortability)
        {
            this.comfortability = comfortability;
        }
        public void set_warmer(bool warmer)
        {
            this.seat_warmer = warmer;
        }
        public Seat(string comfortibility, bool warmer)
        {
            this.seat_warmer = warmer;
            this.comfortability=comfortibility;
        }
        public void display_seat()
        {
            Console.WriteLine("seat_warmer: " + this.seat_warmer);
            Console.WriteLine("Seat_comfortibility:" + this.comfortability);
        }
    }

    public class Wheel
    {
        int circumference;
        public Wheel(int circumference)
        {
            this.circumference = circumference;
        }

        public void display_wheel()
        {
            Console.WriteLine("Wheel_Size" + this.circumference);
        }

    }


    public class Engine
    {
        int max_fuel_consumption;
        int max_energy_production;
        int average_RPM;

        public Engine(int MaximumFuelConsumption, int MaximumEnergyConsumption, int AverageRPM)
        {
            this.max_fuel_consumption = MaximumFuelConsumption;
            this.max_energy_production = MaximumEnergyConsumption;
            this.average_RPM = AverageRPM;
        }
        public void display_Engine()
        {
            Console.WriteLine("Maxmimum Fuel Consumption: "+ this.max_fuel_consumption);
            Console.WriteLine("Maximum Energy Production: " + this.max_energy_production);
            Console.WriteLine("Average RPM" + this.average_RPM);

        }


    }


    public class Door
    {
        string opening_mode;

        public Door(string opening_mode)
        {
            this.opening_mode = opening_mode;
        }

        public void display_door()
        {
            Console.WriteLine("Opening Mode: " + this.opening_mode);
        }
    }

}
