using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace dzdz
{
    abstract class Car
    {
        public delegate void Start();
        public delegate void Message();
        public event Message Display;

        public int My_Speed(Random rnd, int r1, int r2)
        {
            int speed;
            return speed = rnd.Next(r1, r2 + 1);
        }

        public void Win(string name)
        {
            Console.WriteLine($"{name} arrived");
        }
        public void Win(string name,int speed)
        {
            Console.WriteLine($"{name} {speed}");
        }

        public void Go(string name, int speed)
        {
            int distance = 0;
            Display += () => Win(name,speed);
            for (int i = 0; i < 110; i += 10, distance += 10)
            {
                Display();
                Thread.Sleep(speed);
                if (distance == 100)
                    Display -= () => Win(name, speed);
                Display += () => Win(name);
                Display();
                break;
            }
        }
    }
}
