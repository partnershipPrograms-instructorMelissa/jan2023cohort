class Enemy : Attack
{
    public string EnemyName;
    private int Health;

    public List<string> AttackList { get; set; }

    public int _Health
    {
        get
        {
            return Health;
        }
    }

    public void RandomAttack()
    {
        Random rnd = new Random();

        List<string> attackChoices = AttackList;

        int fIndex = rnd.Next(attackChoices.Count);

        Console.WriteLine($"Your Attack is: {attackChoices[fIndex]}");
    }
    public void PerformAttack()
    {
        if(AttackName == "punch"){
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

        Console.WriteLine($"{EnemyName} attacks {Target}, dealing {DamageAmount} damage {AttackName} and reducing {Target}'s health to {_Health}!!");
    }

    public Enemy(string enemyName, string attackName, int damageAmount, string target) : base(attackName, damageAmount, target)
    {
        EnemyName = enemyName;
        Health = 100;
        AttackList = new List<string>();
     }
}