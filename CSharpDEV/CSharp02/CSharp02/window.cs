using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp02
{
    internal class window
    {
        //khai báo các trường
        protected int top;
        protected int left;

        //phương thức khởi tạo
        public window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        //phương thức virtual vẽ cửa sổ
        public void DrawWindow()
        {
            Console.WriteLine("window draw Window at {0} ,{1}", top,left);
        }
    }
}
