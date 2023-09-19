using System.Reflection.Metadata;

namespace Lession01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kiểu dữ liệu
            //int long short byte
            int number = 12;
            Console.WriteLine(number);

            //kiểu số thực: float double decimal
            //float kiểu số thực có độ chính xác kém nhất
            //double: kiểu số thực có độ chính xác cao
            //decimal: kiểu số thực có độ chính xác cao

            double mark = 2.5;
            Console.WriteLine(mark);

            //kiểu kí tự và chuỗi
            //char: kiểu dữ liệu Unicode, kích thước 16b-bit
            //string : kiểu chuỗi kí tự 
            string name = "DEVMaster";
            Console.WriteLine(name);

            //kiểu logic
            //bool: trả về giá trị "true" hoặc "fasle"
            bool check = false;
            Console.WriteLine(check);

            //kiểu ngày và thời gian
            //dateTime: biểu diễn ngày và thời gian
            //timeSpan: biểu diễn 1 khoảng thời gian
            DateTime dateOFBirh = new DateTime(2023,9,18);
            Console.WriteLine(dateOFBirh.ToString("dd-MM-yyyy"));

            //đặt tên biến 
            string fullName = "devmaster";
            string FullName = "DEV";
            Console.WriteLine(fullName);
            Console.WriteLine(FullName);

            //các toán tử
            //số học
            int a = 1;
            int b = 2;
            int c = a * b;
            Console.WriteLine(c);

            //so sánh
            bool d = a > b;
            Console.WriteLine(d);

            //logic 
            int e = 2;
            bool f = a < b && b == e;
            Console.WriteLine(f);

            //gán
            int g = 3;
            g += 3;
            Console.WriteLine(g);

            //tăng giảm
            int h = 4;
            int i = 5;

            h++;
            i--;
            Console.WriteLine(h);
            Console.WriteLine(i);

            //nối chuỗi
            string str1 = "DEV";
            string str2 = "master";
            string result = str1 + str2;
            Console.WriteLine(result);

            //điều kiện
            int k = 1;
            int m = 2;

            string numberReSult = (k > m) ? "k lớn hơn m" : "k nhỏ hơn m";
            Console.WriteLine(numberReSult);
        }
    }
}