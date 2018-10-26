using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Lesson_1_OOP
{
    public static partial class Lesson
    {

        public static void InheritanceTransportExample()
        {
            var transport = new FuelCar() { FuelUsage = 10, Fuel = 45, Distance = 25045 };
            var transport2 = new Transport { Distance = 34, MaxSpeed = 5 };

            var fuel = new FuelCar(){ Engine = 20 };
            var electrofuel = new FuelCar(){ Engine = 10 };

            var exem = new FuelCar(30);
            var exem2 = new FuelCar(20);
            

            Transport unknowedTransport = new Transport { Distance = 34, MaxSpeed = 5 };
            unknowedTransport = new FuelCar() { FuelUsage = 10, Fuel = 45, Distance = 25045 };

            FuelCar maserati = new FuelCar() { FuelUsage = 10, Fuel = 45, Distance = 25045 };
            Transport winner = maserati;
            FuelCar firstPlace = (FuelCar)winner;

            var conclusion = exem > exem2 ? "Yeah, more" : "Not enough";
            var conclusion2 = exem == exem2 ? "The same" : "Not so close";
            Console.WriteLine($"{conclusion}::::{conclusion2}");

        }
    }

    public class Transport
    {
        public int Weight { get; set; }
        public int Height { get; set; }
        public int Length { get; set; }

        public int MaxSpeed { get; set; }
        public float Distance { get; set; }

        public virtual void Move(float km)
        {
            this.Distance += km;
        }
    }

    public class Car : Transport
    {
        public float Engine { get; set; }

        
    }

    public class FuelCar : Car
    {
        public int Tank { get; set; }
        public float Fuel { get; set; }
        public float FuelUsage { get; set; }

        public FuelCar(float engine = 0)
        {
            this.Engine = engine;
        }

        public static bool operator >(FuelCar engine, FuelCar engine2)
        {
            return engine.Engine > engine2.Engine;
        }

        public static bool operator <(FuelCar engine, FuelCar engine2)
        {
            return engine.Engine > engine2.Engine;
        }

        public static bool operator ==(FuelCar engine, FuelCar engine2)
        {
            return engine.Engine == engine2.Engine;
        }

        public static bool operator !=(FuelCar engine, FuelCar engine2)
        {
            return engine.Engine != engine2.Engine;
        }

        public override void Move(float km)
        {
            base.Move(km);
            this.Fuel -= km * FuelUsage / 100;
        }
    }

    public class ElectroCar : Car
    {
        public int Battery { get; set; }
        public float Charged { get; set; }
        public float DistanceBattery { get; set; }

        

        public override void Move(float km)
        {
            base.Move(km);
            this.Charged -= Battery * km / DistanceBattery;
        }
    }
}

    
