using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class Facade 
    {
        public void NewTask()
        {

            TaskSpawner taskSpawner = new TaskSpawner();
            TaskPriority.Kind prior = TaskPriority.Kind.low;
            Console.WriteLine("What kind of priority?");
            Console.WriteLine("1 - 4, where 1 low, 4 highest");
            string temp_prior = Console.ReadLine();
            Console.WriteLine(temp_prior);
            switch (temp_prior)
            {
                case "2":
                    prior = TaskPriority.Kind.medium;
                    taskSpawner.CreateTask(prior);
                    break;
                case "3":
                    prior = TaskPriority.Kind.average;
                    taskSpawner.CreateTask(prior);
                    break;
                case "4":
                    prior = TaskPriority.Kind.highest;
                    taskSpawner.CreateTask(prior);
                    break;
                default:
                    taskSpawner.CreateTask(prior);
                    break;
            }
            
        }
        public void DeleteTask()
        {
            Console.WriteLine("What task delete? Enter id");
            Manager.instance.showmass();
            int id = Convert.ToInt32(Console.ReadLine());
            Manager.instance.delete(id);
        }
        public void ShowTasks()
        {
            Manager.instance.showmass();
        }
    }
}
