using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class phone
    {
        public abstract void Phone();
    }
    
    class model:phone
    {
        public override void Phone()
        {
            Console.WriteLine("Iphone");
        }

        public model()
        {
            Console.WriteLine("14 pro");
        }
    }
    class spec:model,ram
    {
        public void ramgb()
        {
            Console.WriteLine("3GB ram");
        }

        public void spci(string c)
        {
            Console.WriteLine("color " + c);
        }
        public void spci(Int16 s)
        {
            Console.WriteLine("Storage" + s);
        }
        
    }
    interface ram
    {
        void ramgb();
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            spec s = new spec();
            s.Phone();
            s.spci("black");
            s.spci(128);
            s.ramgb();
            Console.ReadKey();
        }
    }
}
