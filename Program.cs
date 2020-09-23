using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace dzdz
{
    class Program
    {
        static void Main(string[] args)
        {
            Sport_Car car = new Sport_Car();
            Bus bus = new Bus();
            Cargo_Car cargo_Car = new Cargo_Car();
            Automobile automobile = new Automobile();
            List<Thread> threads = new List<Thread>()
            {
                new Thread(cargo_Car.Ride),
                new Thread(car.Ride),
                new Thread(bus.Ride),
                new Thread(automobile.Ride)
            };
            foreach (Thread list in threads)
            {
                list.Start();
            }
            Console.ReadKey();
        }
    }
    
}