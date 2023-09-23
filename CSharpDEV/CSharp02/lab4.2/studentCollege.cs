using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4._2
{
    internal class studentCollege: student
    {
        protected double score1, score2, score3 ;

        //contructor
        public studentCollege(string name, int year, double score1, double score2, double score3) : base(name, year)
        {
            this.score1 = score1;
            this.score2 = score2;
            
            this.score3 = score3;
        }
        //ghi đè phương thức tính tb điểm
        public override double Average()
        {
            return (score1 + score2 + score3)/3;
        }
        //hiển thị thông tin
        public new void display()
        {
            base.display();
            Console.WriteLine("score1 : {0:N}", score1);
            Console.WriteLine("score2 : {0:N}", score2);
            Console.WriteLine("score3 : {0:N}", score3);

        }
    }
}
