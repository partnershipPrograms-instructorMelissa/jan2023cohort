class Enemy : Attack
{
    public string EnemyName;
    public int Health; 
    public string Target; 
    public List<string> AttackList; 
    public virtual void RandomAttack()
    {
        Random rnd = new Random();

        List<string> attackChoices = AttackList;

        int fIndex = rnd.Next(attackChoices.Count);

        Console.WriteLine($"Your Attack is: {attackChoices[fIndex]}");
    }
    public virtual void PerformAttack(Enemy Target)
    {
        if (AttackName == "punch")
        {
            DamageAmount = 15;
            Health -= DamageAmount;
        }
        if (AttackName == "throw")
        {
            DamageAmount = 20;
            Health -= DamageAmount;
        }
        if (AttackName == "fireball")
        {
            DamageAmount = 25;
            Health -= DamageAmount;
        }
        Console.WriteLine($"{EnemyName} attacks {Target}, dealing {DamageAmount} damage {AttackName} and reducing {Target}'s health to {Target.Health}!!");
    }

    public Enemy(string enemyName, string attackName, int damageAmount) : base(attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 100;
        AttackList = new List<string>();
        Target = "Sam";
    }
}