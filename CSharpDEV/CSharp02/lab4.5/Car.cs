using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._5
{
    // Car class implements the IMovable interface
    public class Car : IMovable
    {
        // declare the underlying field used by the
        // Started property of the IDrivable interface
        private bool started = false;

        // implement the Start() method of the IDrivable interface
        public void Start()
        {
            Console.WriteLine("car started");
            started = true;
        }
        // implement the Stop() methodof the IDrivable interface
        public void Stop()
        {
            Console.WriteLine("car stopped");
            started = false;
        }
        // implement the Started property of the IDrivable interface
        public bool Started
        {
            get
            {
                return started;
            }
        }
        // implement the TurnLeft() method of the ISteerable interface
        public void TurnLeft()
        {
            Console.WriteLine("car turning left");
        }

        // implement the TurnRight() method of the ISteerable interface
        public void TurnRight()
        {
            Console.WriteLine("car turning right");
        }
        // implement the Accelerate() method of the IMovable interface
        public void Accelerate()
        {
            Console.WriteLine("car accelerating");
        }

        // implement the Brake() method of the IMovable interface
        public void Brake()
        {
            Console.WriteLine("car braking");
        }
    }
}
