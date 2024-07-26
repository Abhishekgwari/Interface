using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Interface1
    {
        void Test();
        void Show();

    }

    interface Interface2
    {
        void Test();
        void Show();
    }
    internal class MultipleInheritenceTest :Interface1, Interface2
    {
        public void Test()
        {
            Console.WriteLine("Interfaces method  implemented in child class ");
        }
        void Interface1.Show()
        {
            Console.WriteLine("Declared in interface 1 and implemented in class ");
        }

        void Interface2.Show()
        {
            Console.WriteLine("Declared in interface 2 and implemented in class ");
        }
        static void Main(string[] args)
        {
            MultipleInheritenceTest obj = new MultipleInheritenceTest();
            obj.Test();
            Interface1 i1 = obj;
            i1.Show();
            Interface2 i2 = obj;
            i2.Show();
            Console.ReadLine();
        }
    }
}
