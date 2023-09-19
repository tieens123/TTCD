namespace lap2_bai2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id;
            string name;
            string address;
            DateTime birthday;
            int salary;
            int bonus;
            int totalSalary;

            // Nhập thông tin nhân viên từ người dùng
            Console.WriteLine("Nhập ID nhân viên: ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập tên nhân viên: ");
            name = Console.ReadLine();

            Console.WriteLine("Nhập địa chỉ nhân viên: ");
            address = Console.ReadLine();

            Console.WriteLine("Nhập ngày sinh nhân viên (dd/MM/yyyy): ");
            string[] birthday = Console.ReadLine().Split("/");
            birthday = new DateTime(int.Parse(birthday[2]), int.Parse(birthday[1]), int.Parse(birthday[0]));

            Console.WriteLine("Nhập lương nhân viên: ");
            salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập tiền thưởng nhân viên: ");
            bonus = Convert.ToInt32(Console.ReadLine());

            // Tính tổng lương
            totalSalary = salary + bonus;

            // Hiển thị thông tin nhân viên
            Console.WriteLine("Thông tin nhân viên:");
            Console.WriteLine("ID: {0}", id);
            Console.WriteLine("Tên: {0}", name);
            Console.WriteLine("Địa chỉ: {0}", address);
            Console.WriteLine("Ngày sinh: {0}", birthday);
            Console.WriteLine("Lương: {0}", salary);
            Console.WriteLine("Tiền thưởng: {0}", bonus);
            Console.WriteLine("Tổng lương: {0}", totalSalary);
        }
    }
}