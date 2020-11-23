using InheritanceDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Id = 0257;
            student.Name = "Yannick";
            student.Adress = "Zondernaamstraat 17";
            student.Phone = "0478912345";
            student.Marks = 9;
            student.Fees = 152.17;
            student.ClassName = "C#";
            Console.WriteLine(student.ToString());


            Teaching teacher = new Teaching();
            teacher.Id = 0725;
            teacher.Name = "Kenan";
            teacher.Adress = "Zondernaamlaan 82";
            teacher.Phone = "0123/456789";
            teacher.JobTittle = "Prof.";
            teacher.Salary = 2165.38;
            teacher.Qualification = "Master";
            teacher.Subject = ".NET";
            Console.WriteLine(teacher.ToString());


            NonTeaching nonTeaching = new NonTeaching();
            nonTeaching.Id = 0318;
            nonTeaching.Name = "Patrick";
            nonTeaching.Adress = "Zondernaamweg 101";
            nonTeaching.Phone = "0987/654.321";
            nonTeaching.JobTittle = "Dir. Technisch";
            nonTeaching.Salary = 2703.86;
            nonTeaching.ManagerName = "Dhr. Peeters";
            nonTeaching.ManagerId = 4;
            Console.WriteLine(nonTeaching.ToString());
        }
    }
}
