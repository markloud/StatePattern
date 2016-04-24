using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior w = new Warrior();
            w.ShowHealth();
            w.Battle();
            w.ShowHealth();
            w.Battle();
            w.ShowHealth();
            w.Battle();
            w.ShowHealth();
            w.Battle();
            w.ShowHealth();

            Console.ReadKey();
        }
    }
}
