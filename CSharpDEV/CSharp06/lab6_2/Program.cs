namespace lab6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //tạo sortedlist generic 
            SortedList<string, string > listEm = new SortedList<string, string>();
            //đưa dữ liệu vào
            listEm.Add("E01", "Tran Thi Thuy");
            listEm.Add("E02", "Le Hai Ha");
            listEm.Add("E03", "Nguyen Van Hung");
            listEm.Add("E04", "Hoang Thi Thom");
            listEm.Add("E05", "Trinh Van Chien");
            //in danh sách
            Console.WriteLine("Danh sach nhan vien");
            foreach(var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);

            }
            //tìm kiếm tất cả nhân viên có tên bắt đầu bằng chữ th
            Console.WriteLine("Danh sach nhan vien bat dau bang chu th: ");
            foreach (var key in listEm.Keys)
            {
                if (listEm[key].StartsWith("Th"))
                Console.WriteLine(key + ":" + listEm[key]);
            }
            //xóa nhân viên có mã E04
            listEm.Remove("E04");
            //kiểm tra nếu chưa có nv E06 thì thêm vào
            if (!listEm.ContainsKey("E06"))
            listEm.Add("E06", "Nguyen Hoai Linh");
            //in danh sách sau khi xóa,thêm
            Console.WriteLine("danh sach nhan vien sau khi xoa them");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }


        }
    }
}