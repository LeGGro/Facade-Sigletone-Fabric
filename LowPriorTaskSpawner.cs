using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class LowPriorTaskSpawner: ITaskSpawner
    {
        public void Spawn()
        {
            Console.WriteLine("Low Spawned Success");
            Random random = new Random();
            int ID = Convert.ToInt32("10" + Convert.ToString(random.Next(1000, 10000)));
            Manager.instance.app(ID);
        }

    }
}
