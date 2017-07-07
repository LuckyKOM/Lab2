using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlassianTrackingSystem
{
    public class Company
    {
        /// <summary>
        /// Singleton class for a company
        /// </summary>
        public List<Manager> ManagerList { get; set; }
        public List<Developer> DeveloperList { get; set; }
        public List<Tester> TesterList { get; set; }
        public List<Task> TaskList { get; set; }
        private static Company instance;
        public static Company Instance
        {
            get
            {
                if (instance == null) instance = new Company();
                return instance;
            }
        }

        private Company() { }     

    }
}
