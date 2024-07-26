using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface ITestInterface
    {
        void Add(int a, int b);
        
    }
    interface ITestInterface2 : ITestInterface
    {
        void Sub(int a, int b);
    }

    class Implementationclass : ITestInterface2
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main(string[] args)
        {
            Implementationclass obj = new Implementationclass();
            ITestInterface2 i = obj;

            i.Add(100, 30);
            i.Sub(78, 23);

            // obj.Add(100, 30);
            // obj.Sub(78, 23);
            Console.ReadLine();
        }
        }
}
