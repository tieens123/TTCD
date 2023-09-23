namespace lab4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo sinh viên cao đẳng và in ra thông tin
            Console.WriteLine("student of college:");
            studentCollege sv1 = new studentCollege("hanh",1992,9.5,8,7);
            sv1.display();
            Console.WriteLine("average of score: {0}", sv1.Average());
            //khởi tạo sinh viên đại học và in ra thông tin
            Console.WriteLine("student of university:");
            studentUniversity sv2 = new studentUniversity("thanh", 1990, 6, 8, 7, 9);
            sv2.display();
            Console.WriteLine("average of score: {0}", sv2.Average());
        }
    }
}