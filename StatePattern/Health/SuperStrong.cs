using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Health
{
    public class SuperStrong : IHealth
    {
        void IHealth.DoBattle(Warrior w)
        {
            //warrior can transition to another state based on the outcome
            w.SetHealth(new Normal());
        }
    }
}
