namespace lab4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                // create a Car object
                Car myCar = new Car();
                // call myCar.Start()
                Console.WriteLine("Calling myCar.Start()");
                myCar.Start();
                // call myCar.TurnLeft()
                Console.WriteLine("Calling myCar.TurnLeft()");
                myCar.TurnLeft();
                // call myCar.Accelerate()
                Console.WriteLine("Calling myCar.Accelerate()");
                myCar.Accelerate();
                Console.ReadLine();
            }
        }
    }
}