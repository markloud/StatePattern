using StatePattern.Health;
using System;

namespace StatePattern
{
    public class Warrior
    {
        private IHealth health = new Normal();  //start as normal health

        public void Battle()
        {
            health.DoBattle(this);  //calls the health to exhibit the behavior
        }

        public void SetHealth(IHealth health)
        {
            this.health = health;
        }

        public void ShowHealth()
        {
            Console.WriteLine("Warrior is now: " + health.GetType().ToString());
        }
    }
}