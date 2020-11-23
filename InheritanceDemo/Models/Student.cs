using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Models
{
    public class Student : Person
    {
        public string ClassName { get; set; }
        public int Marks { get; set; }
        public double Fees { get; set; }

        public override string ToString()
        {
            string s = $"Id: {Id} Name: {Name} Adress: {Adress} Phone: {Phone} Mark: {Marks} Fees: {Fees}";
            return s;
        }
    }
}
