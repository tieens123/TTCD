﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6._1
{
    internal class Product
    {
        //khai báo trường
        string name;
        double cost;
        int onhand;

        //contructor
        public Product (string n, double c, int o)
        {
            name = n;
            cost = c;
            onhand = o;

        }
        //ghi đè phương thức
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C} On hand: {2}", name, cost, onhand);
        }
    }
}
