
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._4
{
    class Staff : IPerson
    {
        //thực thi các phương thức giao diện
        public void Insert( ) 
        {
            Console.WriteLine("da luu đối tượng: " + obj);
        }
        public void Delete( ) 
        {
            Console.WriteLine("da xoa doi tuong: " + obj);
        }
        public void Update( ) 
        {
            Console.WriteLine("da cap nhat doi tuong: " + obj);
        }
        public void Display()
        {
            Console.WriteLine("thong tin doi tuong: " + obj);
        }
    }
}
