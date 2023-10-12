using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_3
{
    internal class Student
    {
        public string Id { get; set; }
        public string FirsName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public double Avg { get; set; }

        //ghi đè phương thức
        public override string ToString()
        {
            return "\nId:" + Id + "\nFullName:"+ FirsName +" " + LastName + "\nGender:" 
                + (Gender ?  "Male" : "Famale") + "\nAverage mark: " + Avg;
        }
    }
}
