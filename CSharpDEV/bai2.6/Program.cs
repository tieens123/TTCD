namespace bai2._6
{
    internal class Program
    {
        /// <summary>
        /// su dung foraech in ra danh sach cac phan tu mang
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //khai bao va khoi tao
            string[] name = { "thang", "long", "hoa", "dao" };
            Console.WriteLine("danh sach sv: \n");
            foreach(var n in name)
            {
                Console.WriteLine(n);
            }
        }
    }
}