using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class TaskSpawner
    {
        public TaskSpawner()
        { }
        public void CreateTask(TaskPriority.Kind taskPriority)
        {
            TaskPriority.Kind prior = taskPriority;
            
            switch (taskPriority)
            {
                case TaskPriority.Kind.medium:
                    MeduimPriorTaskSpawner meduim = new MeduimPriorTaskSpawner();
                    meduim.Spawn();
                    break;
                case TaskPriority.Kind.average:
                    AveragePriorTaskSpawner average = new AveragePriorTaskSpawner();
                    average.Spawn();
                    break;
                case TaskPriority.Kind.highest:
                    HighestPriorTask highest = new HighestPriorTask();
                    highest.Spawn();
                    break;
                default:
                    LowPriorTaskSpawner low = new LowPriorTaskSpawner();
                    low.Spawn();
                    break;
            }
        }
        
    }
}
