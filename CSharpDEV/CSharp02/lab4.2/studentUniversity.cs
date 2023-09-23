﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace lab4._2
{
    internal class studentUniversity:studentCollege
    {
        protected double score4;
        //contructor
        public studentUniversity(string name, int year, double score1, double score2, double score3, double score4)
            :base(name,year, score1, score2, score3)
        {
            this.score4 = score4;
        }
        //phương thức tính điểm trung bình
        public override double Average()
        {
            return (score1 + score2 + score3 + score4)/4;
        }
        //phương thức hiển thị thông tin
        public new void display()
        {
            base.display();
            Console.WriteLine("score4 : {0:N}", score4);
        }

    }
}
