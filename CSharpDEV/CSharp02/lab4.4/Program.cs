using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tao 1 nhân viên
            Staff.Insert(data);
            Staff.Delete(data);
            Staff.Update(data);
            Staff.Display(data);
            //tao sinh viên
            IPerson student = new Student()
            {
                Id = "s10",
                Name = "CHUNGLD",
                Age = 20
            };
            //hiển thị dữ liệu
            student.Display(student);
        }
    }
}