namespace StatePattern.Health
{
    public class Normal : IHealth
    {
        void IHealth.DoBattle(Warrior w)
        {
            //warrior can transition to another state based on the outcome
            w.SetHealth(new Weak());
        }
    }
}