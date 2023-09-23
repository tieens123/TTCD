using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._4
{
    class Student : IPerson
    {
        //khai báo thuộc tính
        public string Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        //thực thi các phương thức từ giao diện
        public void Insert(object obj)
        {
            Console.WriteLine("da luu doi tuong: " + obj);
        }
        public void Delete(object obj)
        {
            Console.WriteLine("da xoa doi tuong: " + obj);
        }
        public void Update(object obj)
        {
            Console.WriteLine("da cap nhat doi tuong: " + obj);
        }
        public void Display(object obj)
        {
            Student st = (Student)obj;
            Console.WriteLine("id: " + st.Id);
            Console.WriteLine("name: " + st.Name);

            Console.WriteLine("age: " + st.Age);

        }
    }
}
