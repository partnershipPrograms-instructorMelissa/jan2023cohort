class Ranged : Enemy
{
    public int Distance;

    public override void PerformAttack()
    {
        int myDistance = Distance;

        if(myDistance < 10)
        {
            Console.WriteLine($"Cannot perform attack! Your distance is too low. Current distance is {myDistance}");
            
        } else {
            if (AttackName == "arrow")
            {
                DamageAmount = 20;
                Health -= DamageAmount;
            }
            if (AttackName == "knife")
            {
                DamageAmount = 15;
                Health -= DamageAmount;
            }
            Console.WriteLine($"{EnemyName} dealt {DamageAmount} damage {AttackName} reducing health to {Health}!!");
        }
    }

    public Ranged(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        Distance = 5;
    }
}