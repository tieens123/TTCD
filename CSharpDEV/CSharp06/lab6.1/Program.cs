using System.Collections;

namespace lab6._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo Arr
            ArrayList inv = new ArrayList();
            //thêm phần tử vào danh sách
            inv.Add(new Product("a", 5.9, 3));
            inv.Add(new Product("b",8.2,2));
            inv.Add(new Product("c", 3.5, 4));

            inv.Add(new Product("d", 1.8, 8));
            //in ra danh sách phần tử
            Console.WriteLine("Product list: ");
            foreach (Product i in inv)
            {
                Console.WriteLine("  " + i);
            }   
        }
    }
}