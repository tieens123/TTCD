using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp02
{
    internal class button: window
    {
        //phương thức khởi tạo
        public button( int top, int left): base(top, left) { }

        //ghi đè phương thức
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }
}
