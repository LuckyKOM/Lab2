using System;
using System.Collections.Generic;

namespace AtlassianTrackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = Company.Instance ; // one - instance                                
           //var devList= Filler.Fill<Developer>(10);
           // var testerlist = Filler.Fill<Tester>(4);
           // var taskList = Filler.Fill<Task>(4);
            // var dev1 = Filler.Fill<Developer>(1);
            // var dev2 = Filler.Fill<Developer>(1);
            var dev1 = new Developer();
            var dev2 = new Developer();
            Console.WriteLine(dev1);
            Console.WriteLine(dev2);
            Console.WriteLine(dev1.CompareTo(dev2));
            Console.ReadLine();
        }
    }
}
