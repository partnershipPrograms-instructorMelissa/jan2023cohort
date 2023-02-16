class Ranged : Enemy
{
    public int Distance;
    public override void PerformAttack(Enemy Target)
    {
        int myDistance = Distance;

        if(myDistance < 10)
        {
            Console.WriteLine($"Cannot perform attack! Your distance is too low. Current distance is {myDistance}");
            
        } else {
            if (AttackName == "arrow")
            {
                DamageAmount = 20;
                Target.Health -= DamageAmount;
            }
            if (AttackName == "knife")
            {
                DamageAmount = 15;
                Target.Health -= DamageAmount;
            }
            Console.WriteLine($"{EnemyName} dealt {DamageAmount} damage {AttackName} reducing health to {Target.Health}!!");
        }
    }

    public void DashMethod()
    {
        int currentDash = 20;
        Distance += currentDash;

        Console.WriteLine($"Your dash amount is {currentDash}, you now have a distance of {Distance}");  
    }

    public Ranged(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        Distance = 5;
    }
}