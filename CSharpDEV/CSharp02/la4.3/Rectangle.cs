using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace la4._3
{
     class Rectangle:shape
    {
        public void input()
        {
            Console.WriteLine("nhập chiều dài: ");
            lenght = int.Parse(Console.ReadLine());
            Console.WriteLine("nhập chiều rộng: ");
            width = int.Parse(Console.ReadLine());
        }
        //ghi đè phương thức tính diện tích
        public override float area()
        {
            return lenght * width;
        }
        //ghi đè phương thức tính chu vi
        public override float circumference()
        {
            return 2* width *lenght;
        }
    }
}
