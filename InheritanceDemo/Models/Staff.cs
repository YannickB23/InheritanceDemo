using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Models
{
    public class Staff : Person
    {
        public string JobTittle { get; set; }
        public double Salary { get; set; }
    }
}
