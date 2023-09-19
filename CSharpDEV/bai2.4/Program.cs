namespace bai2._4
{
    internal class Program
    {
        /// <summary>
        /// chuong trinh in ra cac so nguyen tu 2-100
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //khai bao bien danh dau
            bool check_i;
            Console.WriteLine("danh sach so nguyen tu 2-100: ");
            //duyet tu 2-100
            for (int i = 2;i<=100;i++)
            {
                check_i = true;
                for(int j =2;j<=i;j++)
                {
                    if(i % j ==0)
                    {
                        check_i=false;
                        break;
                    }
                }
                if (check_i)
                    Console.WriteLine("{0}", i);
            
            }
        }

    }
}