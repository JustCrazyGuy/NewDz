using System;
using System.Collections.Generic;
using System.Text;

namespace dzdz
{
    class Cargo_Car : Car
    {
        public string Name = "Cargo car";
        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 700, 1000));
        }
    }
}
