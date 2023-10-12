using System.Text;
using Tulam6_1;



namespace Tulam6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Book> books = new List<Book>()
        {
            new Book(1, "Đắc nhân tâm", "Dale Carnegie", "NXB Trẻ", 2012, 99.000),
            new Book(2, "Tư duy nhanh và chậm", "Daniel Kahneman", "NXB Tri thức", 2012, 129.000),
            new Book(3, "Nhà Giả kim", "Paulo Coelho", "NXB Văn hóa - Văn nghệ", 2013, 79.000),
            new Book(4, "Đắc nhân tâm - phiên bản mới", "Dale Carnegie", "NXB Trẻ", 2014, 109.000),
            new Book(5, "Tư duy phản biện", "Rhett Smith", "NXB Dân trí", 2014, 89.000),
            new Book(6, "Nhà giả kim - phiên bản mới", "Paulo Coelho", "NXB Văn hóa - Văn nghệ", 2015, 89.000),
            new Book(7, "Đắc nhân tâm - phiên bản mới", "Dale Carnegie", "NXB Trẻ", 2016, 99.000),
            new Book(8, "Tư duy phản biện", "Rhett Smith", "NXB Dân trí", 2017, 99.000),
            new Book(9, "Nhà giả kim - phiên bản mới", "Paulo Coelho", "NXB Văn hóa - Văn nghệ", 2018, 99.000),
        };

        // In danh sách các quyển sách tăng dần theo giá
        Console.WriteLine("Danh sách các quyển sách tăng dần theo giá:");
        books.Sort();
        foreach (var book in books)
        {
            Console.WriteLine(book);
        }

        // Tìm quyển sách có title trùng với giá trị nhập từ bàn phím
        Console.WriteLine("Nhập title của quyển sách cần tìm:");
        string title = Console.ReadLine();
        var book = books.Find(x => x.Title == title);
        if (book != null)
        {
            Console.WriteLine("Tìm thấy quyển sách:");
            Console.WriteLine(book);
        }
        else
        {
            Console.WriteLine("Không tìm thấy quyển sách nào có title là '{0}'", title);
        }

        // Đưa ra nhưng quyển sách xuất bản năm 2014
        Console.WriteLine("Danh sách các quyển sách xuất bản năm 2014:");
        foreach (var book in books.Where(x => x.Year == 2014))
        {
            Console.WriteLine(book);
        }

        // Xóa những quyển sách của nhà xuất bản “Nhi Dong”
        Console.WriteLine("Danh sách các quyển sách sau khi xóa:");
        books.RemoveAll(x => x.Publisher == "Nhi Dong");
        }
    }
}