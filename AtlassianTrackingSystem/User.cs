using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlassianTrackingSystem
{
    public enum Seniority  { Junior, Middle, Senior, Lead };
    public class User : IComparable<User>
    {
        /// <summary>
        /// Base class for system members
        /// </summary>
        // private variables
        // public static read only 
      //  public enum Profeciency {Junior, Middle, Senior, Lead } ;
        public Seniority Seniority { get; set; } 
        public  decimal Salary { get; set; }
        public int Capacity { get; set; } 
        public User()
        {
            Capacity = new Random().Next(1, 30);
            Salary = new Random().Next(500, 3000);
            Array values = Enum.GetValues(typeof(Seniority));
            Seniority = (Seniority) new Random().Next(values.Length);
        }
        public void DoTask()
        { }
        public void ReturnTask()
        { }
        public override string ToString()
        {
            var fullDescription = new StringBuilder("");
                         fullDescription.Append("\nCapacity= " + Capacity);
                        fullDescription.Append(" Salary=" + Salary);
                         fullDescription.Append(" Seniority= " + Seniority);
                        return fullDescription.ToString();

        }

        public int CompareTo(User other)
        {
            int firstBetter = 1;
            if ( Seniority.CompareTo( other.Seniority) <= 0 )
                firstBetter = -1;
            return firstBetter;
        }
    }
}
