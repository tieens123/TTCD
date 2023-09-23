using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la4._3
{
    internal class circle:shape

    {
        public void input()
        {
            Console.WriteLine("nhap ban kinh:");
            radius = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float area()
        {
            return 3.14F * radius * radius;
        }
        //ghi đè phương thức tính chu vi
        public override float circumference()
        {
            return 2 * 3.14F * radius;
        }

    }
}
