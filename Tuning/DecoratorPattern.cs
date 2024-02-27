using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Tuning.Inheritance;

namespace Tuning
{
    public class DecoratorPattern
    {
        static void Main12(string[] args)
        {            
            ICar basicCar = new BasicCar();

            // Add features dynamically using decorators
            ICar carWithGPS = new GPSDecorator(basicCar);
            ICar carWithLeatherSeats = new LeatherSeatsDecorator(carWithGPS);

            // Output description and cost
            Console.WriteLine(carWithGPS.GetDescription());
            Console.WriteLine($"Total Cost: ${carWithGPS.GetCost()}");

            Console.WriteLine(carWithLeatherSeats.GetDescription());
            Console.WriteLine($"Total Cost: ${carWithLeatherSeats.GetCost()}");

            // Output:
            // Basic Car, with GPS, with Leather Seats
            // Total Cost: $21000.0

            //        Definition:
            //            The Decorator Pattern is a structural design pattern that allows behavior to be added to individual objects dynamically,
            //            without affecting the behavior of other objects of the same class. It's used to extend or enhance the functionality of objects at runtime.

            //        Explanation:
            //            The ICar interface defines the common operations for all cars.
            //            BasicCar is a concrete implementation of ICar.
            //            CarDecorator is the base decorator class implementing ICar.
            //            Concrete decorators(GPSDecorator, LeatherSeatsDecorator) extend functionality by adding features like GPS or Leather Seats.
            //            Each decorator wraps another ICar object, adding its own functionality.
            //            Decorators can be stacked to add multiple features dynamically.
            //            This way, the Decorator Pattern allows you to add new functionalities to objects dynamically at runtime, without altering their structure or requiring excessive subclassing.
        }
    }

    // Interface for Car
    public interface ICar
    {
        string GetDescription();
        double GetCost();
    }

    // Concrete Car implementation
    public class BasicCar : ICar
    {
        public string GetDescription()
        {
            return "Basic Car";
        }

        public double GetCost()
        {
            return 20000.0;
        }
    }

    // Decorator base class
    public abstract class CarDecorator : ICar
    {
        protected ICar _car;

        public CarDecorator(ICar car)
        {
            _car = car;
        }

        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }

        public virtual double GetCost()
        {
            return _car.GetCost();
        }

    }

    // Concrete Decorator for adding GPS feature
    public class GPSDecorator : CarDecorator
    {
        public GPSDecorator(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", with GPS";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 500.0;
        }
    }

    // Concrete Decorator for adding Leather Seats feature
    public class LeatherSeatsDecorator : CarDecorator
    {
        public LeatherSeatsDecorator(ICar car) : base(car) { }

        public override string GetDescription()
        {
            return _car.GetDescription() + ", with Leather Seats";
        }

        public override double GetCost()
        {
            return _car.GetCost() + 1000.0;
        }
    }

}
