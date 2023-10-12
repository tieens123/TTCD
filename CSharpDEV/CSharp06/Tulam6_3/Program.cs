using System.Drawing;

namespace Tulam6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>
            {
                new Car {Name = "car 1",Color= "red"},
                new Car {Name = "car 2",Color= "yellow"},
                new Car {Name = "car 3",Color= "red"},
                new Car {Name = "car 4",Color= "blue"},
                new Car {Name = "car 5",Color= "green"},

            };
            Console.WriteLine("nhập màu muốn xóa: ");
            string colorToDelete = Console.ReadLine();

            carList.RemoveAll(car => car.Color.ToLower() == colorToDelete.ToLower());

            Console.WriteLine("danh sách car còn lại sau khi xóa: ")
        }
    }
}