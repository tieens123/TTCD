﻿namespace lab2_bai2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("nhao vao ki tu: ");
            ch = (char)Console.Read();
            switch (ch)
            {
                case 'a':
                case 'o':
                case 'e':
                case 'u':
                case 'i': Console.WriteLine("{0} la nguyen am", ch);
                    break;
                default: Console.WriteLine("{0} la phu am", ch);
                    break;

            }
        }
    }
}