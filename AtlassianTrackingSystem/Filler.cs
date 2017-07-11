using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AtlassianTrackingSystem
{
   public static class Filler
    {
       //public enum Type {Developer, Tester, Task};

        // public static List<object> FillSomething(string type, int number)
        /// <summary>
        /// returns collection with specified number of entities of given type
        /// </summary>
        /// <param name="type">  Type of entity to generate a list for </param>
        /// <param name="amount"> Quontity of entities </param>
        /// <returns></returns>
        public static List<T> Fill<T>(int amount) where T : class, new()
        {
            var list = new List<T>();
            if (amount > 1)
            {
                while (amount > 0)
                {
                    var instance = new T();
                    list.Add(instance);
                    amount--;
                }
              
            }
            return list;
        }
       // T res = new T();
       // return res;
        /*{

        //var list = new List<T>();
        switch (type)
            {
            case Type.Developer:
                // var listDev = new List<Developer>(amount);
                // foreach ( var count in )
                return new T();
              /*  for (int i = 1; i < amount; i++ )
                {
                    var developer = new Developer();

                    developer.Capacity = new Random().Next(1, 30);
                    developer.Salary = new Random().Next(500, 3000);
                   Array values= Enum.GetValues (typeof(User.Profeciency));
                  developer.Seniority=  (User.Profeciency ) new   Random().Next(values.Length+1);
                    list.Add(developer);
              // developer.Seniority=  (int)values.GetValue(SeniorIndex );

                 //   developer.Seniority = Developer.Prof.
                }
                //int num = randomDev.Next(1, 20);
                return list;
               // break;
            case Type.Tester:

                break;
            case Type.Task:
                var listTask = new List<Task>(amount);
                for (int i = 1; i < amount; i++)
                {
                    var task= new Task();
                    task.Estimation = new Random().Next(1, 10);
                    task.Difficulty = new Random().Next(1, 4);                   
                }
                break;
            default: break;
                }
        // var listOfTasks = new List<DevTask>();
        return list;
    }*/

    }
}
