using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._4
{
    interface IPerson
    {
        //phương thức insert
        void IPerson(object obj);
        //phương thức xóa
        void Delete(object obj);
        //phương thức sửa
        void Update(object obj);
        //phương thức hiển thị
        void Display(object obj);
    }
}
