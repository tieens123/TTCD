using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp02
{
    internal class listBox: window
    {
        //khai báo trường mới
        private string listBoxContents;
        //phương thức khởi tạo
        public listBox(int top, int left, string contents): base(top,left) 
        { 
            listBoxContents= contents; 
        }

    }
    public override void DrawWindow()
    {
        base.DrawWindow(); // gọi phương thức lớp cơ sở
        Console.WriteLine("Writing string to the listbox: {0}",
        listBoxContents);
    }
}
