namespace StatePattern.Health
{
    public class Weak : IHealth
    {
        void IHealth.DoBattle(Warrior w)
        {
            //warrior can transition to another state based on the outcome
            w.SetHealth(new Strong());
        }
    }
}