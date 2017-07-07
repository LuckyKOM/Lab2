using System;
using System.Collections.Generic;

namespace AtlassianTrackingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var company = Company.Instance ; // one - instance                                
           var devList= Filler.Fill<Developer>(2);
            var testerList = Filler.Fill<Tester>(2);
            var taskList = Filler.Fill<Task>(2);
            Console.Read();
        }
    }
}
