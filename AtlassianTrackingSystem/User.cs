using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlassianTrackingSystem
{
   public class User
    {
        /// <summary>
        /// Base class for system members
        /// </summary>
        // private variables
        // public static read only 
        public enum Profeciency {Junior, Middle, Senior, Lead } ;
        public Profeciency Seniority { get; set; } 
        public  decimal Salary { get; set; }
        public int Capacity { get; set; } // in hours
        public User()
        {
            Capacity = new Random().Next(1, 30);
            Salary = new Random().Next(500, 3000);
            Array values = Enum.GetValues(typeof(Profeciency));
            Seniority = (Profeciency)new Random().Next(values.Length );
        }
        public void DoTask()
        { }
        public void ReturnTask()
        { }

    }
}
