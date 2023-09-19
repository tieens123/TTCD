namespace bai2._3
{
    internal class Program
    {
        private static double x2;

        static void Main(string[] args)
        {
            //khai bao bien

            double a, b, c, delta, x1, x2;
            //nhap abc
            Console.WriteLine("a = ");
            do
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (a == 0);
                Console.WriteLine("b=");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("c=");
            c = Convert.ToInt32(Console.ReadLine());
            //tinh delta
            delta = b * b - 4 * a * c;
            //bien luan
            if (delta < 0)
                Console.WriteLine("phuong trinhh vo nghiem");
            else if (delta == 0)
            {
                Console.WriteLine("phuong trinh co nghiem kep");
                Console.WriteLine("x1=x2={0}", -b / (2 * a));
            }
            else
            {
                Console.WriteLine("phuong trinh co 2 nghiem");
                x1 = (-b + Math.Sqrt(delta))/(2*a);
                Console.WriteLine("x1={0}", x1);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("x2={0}", x2);
            }
        }
    }
}