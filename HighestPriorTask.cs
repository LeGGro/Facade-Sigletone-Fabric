using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class HighestPriorTask: ITaskSpawner
    {
        public void Spawn()
        {
            Console.WriteLine("Highest Spawned Success");
            Random random = new Random();
            int ID = Convert.ToInt32("40" + Convert.ToString(random.Next(1000, 10000)));
            Manager.instance.app(ID);
        }
    }
}
