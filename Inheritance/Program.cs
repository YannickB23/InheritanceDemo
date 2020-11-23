using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Parent
    {
        public int x;
        public Parent(int a)
        {
            x = a + 2;
            Console.WriteLine(x);
            Console.WriteLine("Ik zal als eerste getriggerd worden!");
        }
        public string Name { get; set; }
        //private string Age { get; set; }        //private members kunnen niet worden overgenomen worden door CHILD CLASS
        public void Show1()
        {
            Console.WriteLine("I am parent class method show1");
        }
        public void Show2()
        {
            Console.WriteLine("I am parent class method show2");
        }
    }
    public class Child : Parent
    {
        public Child(int x) : base(x)
        {
            Console.WriteLine("Ik zal als 2de getriggerd worden!");
        }
        public void Show3()
        {
            Console.WriteLine("I am child class method show3");
        }
        public override string ToString()
        {
            string s = $"{Name}";
            return s;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child kid = new Child(23);
            kid.Name = "Vic";
            //kid.Age;      //= private prop

            kid.Show1();
            kid.Show2();
            kid.Show3();

            Console.WriteLine(kid.ToString());
            //Parent p = new Parent();
            //p.Show1();
            //p.Show2();
            //Parent class krijgt NOOIT toegang tot de members van Child class!!!

        }
    }
}
