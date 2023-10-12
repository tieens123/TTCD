//khai báo và khởi tạo danh sách sinh viên sử dụng List generic 
using lab6_3;

List<Student> list = new List<Student>()
            {
                new Student{Id="S10",FirsName="Nguyen Thu",LastName = "Phuong", Avg=9.5},
                new Student{Id="S12",FirsName="Tran Thi",LastName = "Thuy", Avg=9.0},
                new Student{Id="S13",FirsName="Le Hoang",LastName = "Nhat", Avg=8.0},
                new Student{Id="S14",FirsName="Nguyen Van",LastName = "Phong", Avg=6.5},
                new Student{Id="S15",FirsName="Hoang Thi",LastName = "Hue", Avg=9.7},


            };
//in danh sách sinh viên
Console.WriteLine("Danh sách sinh viên:");
foreach (var st in list)
{
    Console.WriteLine(st);
}
//tìm sinh viên có điểm trung bình cao nhất
double max = list[0].Avg;
Student stmax = list[0];
foreach (var st in list)
{
    if (st.Avg > max)
    {
        max = st.Avg;
        stmax = st;
    }
}
//in kết quả
Console.WriteLine("sinh vien co diem cao nhat la: ");
Console.WriteLine(stmax);
