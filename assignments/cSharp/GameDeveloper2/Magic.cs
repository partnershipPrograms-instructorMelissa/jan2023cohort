class Magic : Enemy
{
    public int Heal;
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (ChosenAttack.AttackName == "punch")
        {
            DamageAmount = 25;
            Target.Health -= DamageAmount;
        }
        if (ChosenAttack.AttackName == "throw")
        {
            DamageAmount = 20;
            Target.Health -= DamageAmount;
        }
        if (ChosenAttack.AttackName == "fireball")
        {
            DamageAmount = 10;
            Target.Health -= DamageAmount;
        }
        Console.WriteLine($"{EnemyName} attacks {Target.EnemyName}, dealing {DamageAmount} damage {AttackName} and reducing {Target.EnemyName}'s health to {Target.Health}!!");
    }
    public void HealMethod(Enemy Target)
    {
        Target.Health += this.Heal;
    
        Console.WriteLine($"your new health total is {Target.Health}");
    }
    public Magic(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 80;
        Heal = 40;
        // AttackList = new List<string>();
    }
}