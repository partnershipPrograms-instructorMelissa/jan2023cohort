class Magic : Enemy
{
    public override void PerformAttack(Enemy Target)
    {
        if (AttackName == "fireball")
        {
            DamageAmount = 25;
            Target.Health -= DamageAmount;
        }
        if (AttackName == "lighting bolt")
        {
            DamageAmount = 20;
            Target.Health -= DamageAmount;
        }
        if (AttackName == "staff strike")
        {
            DamageAmount = 10;
            Target.Health -= DamageAmount;
        }
        Console.WriteLine($"{EnemyName} attacks {Target}, dealing {DamageAmount} damage {AttackName} and reducing {Target}'s health to {Target.Health}!!");
    }
    public void HealMethod(Enemy Target)
    {
        int targetEnemy = Target.Health;
             
        targetEnemy += 40;

        Console.WriteLine($"your new health total is {targetEnemy}");
    }
    public Magic(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 80;
        // AttackList = new List<string>();
    }
}