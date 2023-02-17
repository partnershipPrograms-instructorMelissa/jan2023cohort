class Enemy : Attack
{
    public string EnemyName;
    public int Health; 
    public string Target; 
    public List<Attack> AttackList; 
    public virtual Attack RandomAttack()
    {
        Random rnd = new Random();

        List<Attack> attackChoices = AttackList;

        int fIndex = rnd.Next(attackChoices.Count);

        return attackChoices[fIndex];
    }
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health -= ChosenAttack.DamageAmount;

        Console.WriteLine($"{EnemyName} attacks {Target.EnemyName}, dealing {ChosenAttack.DamageAmount} damage {ChosenAttack.AttackName} and reducing {Target.EnemyName}'s health to {Target.Health}!!");
    }

    public Enemy(string enemyName, string attackName, int damageAmount) : base(attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 100;
        AttackList = new List<Attack>()
        {
            new Attack("fireball", 25),
            new Attack("punch", 20),
            new Attack("throw", 15)
        };
        Target = "Sam";
    }
}