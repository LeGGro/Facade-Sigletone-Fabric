using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class AveragePriorTaskSpawner: ITaskSpawner
    {
        public void Spawn()
        {
            Console.WriteLine("Average Spawned Success");
            Random random = new Random();
            int ID = Convert.ToInt32("30" + Convert.ToString(random.Next(1000, 10000)));
            Manager.instance.app(ID);
        }
    }
}
