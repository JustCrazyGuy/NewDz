using System;
using System.Collections.Generic;
using System.Text;

namespace dzdz
{
    class Sport_Car : Car
    {
        public string Name = "Sport car";

        public void Ride()
        {
            Go(Name, My_Speed(new Random(), 500, 800));
        }
    }
}
