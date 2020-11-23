using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo.Models
{
    public class NonTeaching : Staff
    {
        public string ManagerName { get; set; }
        public int ManagerId { get; set; }
    }
}
