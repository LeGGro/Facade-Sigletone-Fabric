using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class MeduimPriorTaskSpawner: ITaskSpawner
    {
        public void Spawn()
        {
            Console.WriteLine("Medium Spawned Success");
            Random random = new Random();
            int ID = Convert.ToInt32("20"+ Convert.ToString(random.Next(1000, 10000)));
            Manager.instance.app(ID);
        }
    }
}
