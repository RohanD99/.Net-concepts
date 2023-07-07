using System;

namespace Project1
{
    //Abstraction-
    public abstract class Vehicle    //cannot be instantiated but can be use as base class
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public Vehicle(string brand, string model)    //properties
        {
            Brand = brand;
            Model = model;
        }

        // Encapsulation-
        public abstract void Start();

        // Polymorphism
        public virtual void Drive()       //virtual allows derived classes to override it
        {
            Console.WriteLine($"Driving the {Brand} {Model}");
        }
    }

    public class Car: Vehicle      //inherits base class
    {
        public Car(string brand, string model) : base(brand, model) { }   //properties of base class

        public override void Start()
        {
            Console.WriteLine($"Driving the {Brand} {Model} on road");
        }
    }

    public class Motorcycle: Vehicle
    {
        public Motorcycle(string brand, string model) : base(brand, model) { }

        public override void Start()
        {
            Console.WriteLine($"Starting {Brand}{Model} by kick-starting");
        }
    }

    class Program
    {
        public Program()
        {

        }

        static void Main(string[] args)
        {
            Vehicle car = new Car("Toyota", "Camry");
            car.Start();
            car.Drive();
            Console.WriteLine();
            Console.ReadLine();

            Vehicle motorcycle = new Motorcycle("Honda", "CBR505R");
            motorcycle.Drive();
            motorcycle.Start();
            Console.WriteLine();
            Console.ReadLine();

        }
    }


}
