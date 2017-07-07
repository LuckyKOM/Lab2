using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtlassianTrackingSystem
{
  public class Task
    {
        //public enum Dif {Easy, Medium, Upmedium, Difficult }

        public enum Urgency {Low, Medium, High };
        public int Estimation { get; set; } //duration of task in hours
        public Urgency Priority { get; set; }
        public int Difficulty { get; set; }
        public Task()
        {
            Estimation = new Random().Next(1, 10);
            Difficulty = new Random().Next(1, 4);
        }
    }
}
