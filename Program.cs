using System;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.NewTask();
            facade.NewTask();
            facade.NewTask();
            facade.NewTask();
            facade.NewTask();
            facade.NewTask();
            facade.NewTask();
            facade.DeleteTask();
            facade.ShowTasks();
        }
    }
}
