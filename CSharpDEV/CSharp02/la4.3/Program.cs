namespace la4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo hình chữ nhật
            Rectangle rec = new Rectangle();
            //nhập dữ liệu
            rec.input();
            //in thông tin
            Console.WriteLine("Dien tich hinh chu nhat la:{0:N}", rec.area());
            Console.WriteLine("Chu vi hinh chu nhat la:{0:N}", rec.circumference());
            //Khởi tạo hình tròn
            circle cir = new circle();
            //nhập dữ liệu
            cir.input();
            //in thông tin
            Console.WriteLine("Dien tich hinh tron la:{0:N}", cir.area());
            Console.WriteLine("Chu vi hinh tron la:{0:N}", cir.circumference());
        }
    }
}