using System;
using System.Collections.Generic;
using System.Text;

namespace dzdz
{
    class Bus : Car
    {
        public string Name = "Bus";
        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 800, 1100));
        }
    }
}
