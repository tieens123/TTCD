using System.Collections;
using System.Text;

namespace Tulam6_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Hashtable weekDays = new Hashtable();

            weekDays.Add(1, "Monday");
            weekDays.Add(2, "Tuesday");
            weekDays.Add(3, "Wendesday");
            weekDays.Add(4, "Thurday");
            weekDays.Add(5, "Friday");
            weekDays.Add(6, "Saturday");
            weekDays.Add(7, "Sunday");


            Console.WriteLine("nhập ngày cần tìm: ");
            string dayToFind = Console.ReadLine();

            if (weekDays.ContainsValue(dayToFind) )
            {
                Console.WriteLine("ngày {0} đã đc tìm thấy", dayToFind);
            }
            else
            {
                Console.WriteLine("không tìm thấy ngày {0}",dayToFind);
            }

            Console.WriteLine("các ngày trong tuần: ");
            foreach(DictionaryEntry weekDay in weekDays)
            {
                Console.WriteLine("Key: {0}, Value: {1}", weekDay.Key, weekDay.Value);
            }

        }
    }
}