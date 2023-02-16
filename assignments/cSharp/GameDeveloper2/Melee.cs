class Melee : Enemy
{
    public override void RandomAttack()
    {
        Random rnd = new Random();

        List<string> attackChoices = AttackList;

        int fIndex = rnd.Next(attackChoices.Count);

        string attackIs = attackChoices[fIndex];

        if(attackIs == "punch")
        {
            DamageAmount = 30;
            Health -= DamageAmount;
        }
        if (attackIs == "kick")
        {
            DamageAmount = 25;
            Health -= DamageAmount;
        }
        if (attackIs == "tackle")
        {
            DamageAmount = 35;
            Health -= DamageAmount;
        }
        Console.WriteLine($"{attackIs} dealing {DamageAmount} damage reducing health by {Health}!!");
    }

    public Melee(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 120;
        AttackList = new List<string>();
    }
}