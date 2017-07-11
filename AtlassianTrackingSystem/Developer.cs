using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlassianTrackingSystem
{
    public class Developer : User, IComparable<Developer>
    {

        public string LanguageKnown { get; set; }
        public int CompareTo(Developer other)
        {
            // int intSeniority = (int)Seniority;
            int firstIsbetter = 1;
            if (Seniority.CompareTo(other.Seniority) <= 0)
            {
                if (Seniority.CompareTo(other.Seniority) < 0)
                    firstIsbetter = -1;
                else if (Salary.CompareTo(other.Salary) < 0)
                    firstIsbetter = 1;
            }
            return firstIsbetter;
        }

        //public static bool operator < (Developer x, Developer y)
        //{

        //}
    }
}
