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
    public void PerformAttack()
    {
        if(AttackName == "punch")
        {
            Health -= DamageAmount;
        }
        if (AttackName == "throw")
        {
            Health -= DamageAmount;
        }
        if (AttackName == "fireball")
        {
            Health -= DamageAmount;
        }

        Console.WriteLine($"{EnemyName} attacks {Target}, dealing {DamageAmount} damage {AttackName} and reducing {Target}'s health to {Health}!!");
    }

    public Enemy(string enemyName, string attackName, int damageAmount) : base(attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 100;
        AttackList = new List<string>();
        Target = "Sam";
    }
}