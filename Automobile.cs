using System;
using System.Collections.Generic;
using System.Text;

namespace dzdz
{
    class Automobile : Car
    {
        public string Name = "Automobile";

        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 600, 900));
        }
    }
}
