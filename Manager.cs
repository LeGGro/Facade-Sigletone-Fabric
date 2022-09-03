using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns
{
    class Manager
    {
        public static Manager instance = new Manager();

        List<int> mass = new List<int>();

        public void app(int id)
        {
            mass.Add(id);
            mass.Sort();
            mass.Reverse();
        }

        public void showmass()
        {
            Console.WriteLine("<><><><><>");
            foreach (int i in mass)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("<><><><><>");
        }
        public void delete(int id)
        {
            mass.RemoveAt(mass.IndexOf(id));
            mass.Sort();
            mass.Reverse();
        }
        private Manager() { }
    }
}
