using System.Text;

namespace Lession1_lab1
{
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ////khai báo biến
            //int Id = 1;
            //string name = "test";
            //int age = 23;
            ////char gender = 'M';
            //string gender = "male";

            ////khai báo hằng số
            //const float percent = 100;

            ////hiển thị giá trị biến và hằng số 
            //Console.WriteLine("dev Id: {0}", Id);
            //Console.WriteLine(name);
            //Console.WriteLine(age);
            //Console.WriteLine(gender);
            //Console.WriteLine(percent);
            

            //bài 1
            Console.WriteLine("   +++++++++              ++++     ++++");
            Console.WriteLine(" ++++++++++++       +++++++++++++++++++");
            Console.WriteLine("+++      +++++     +++++++++++++++++++");
            Console.WriteLine("+++                   ++++    ++++");
            Console.WriteLine("+++                  ++++    ++++");
            Console.WriteLine("+++      +++++    +++++++++++++++++++");
            Console.WriteLine(" ++++++++++++    +++++++++++++++++++");
            Console.WriteLine("   +++++++++      ++++     ++++");

            //bài 2
            Console.OutputEncoding = Encoding.UTF8;
            int Id = 1;
            string name = "Nguyen Văn A"; 
            DateTime dateOFBirh = new DateTime(2023, 9, 18);
            string address = "ac";
            int number = 0123456;
            string email = "tien@123";

            Console.WriteLine("ma nhan vien: {0}" , Id);
            Console.WriteLine("ho ten nhan vien: {0}" , name);
            Console.WriteLine("ngay thang nam sinh: {0}", dateOFBirh.ToString("dd-MM-yyyy"));

            Console.WriteLine("dia chi: {0}" , address);
            Console.WriteLine("sđt: {0}" , number);
            Console.WriteLine("email: {0}" , email);  






        }
    }
}