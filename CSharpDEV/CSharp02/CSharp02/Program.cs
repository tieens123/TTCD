namespace CSharp02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo lớp window
            window win = new window(1,2);

            //khởi tạo lisbox
            listBox lb = new listBox(3,4, "stand alone list box");

            //khởi tạo lớp button
            button b = new button(5, 6);
            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();

            //khởi tạo bằng window
            window[] winArray= new window[3];
            winArray[0] = new window(1,2);
            winArray[1] =new listBox(3,4, "List box in array");
            winArray[2] = new button(5, 6);

            for (int i =0;i<3;i++)
            {
                winArray[i].DrawWindow();

            }
        }
    }
}