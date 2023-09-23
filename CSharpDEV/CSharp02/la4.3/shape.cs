using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la4._3
{
    abstract class shape
    {
        protected float radius, lenght, width;
        //khai bao truu tuong
        public abstract float area();//dien tich
        public abstract float circumference();//chu vi

    }
}
