class Melee : Enemy
{

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        base.PerformAttack(Target, ChosenAttack);
    }
    public void RageMethod(Enemy Target)
    {
        Random rnd = new Random();

        List<string> attackChoices = AttackList;

        int fIndex = rnd.Next(attackChoices.Count);

        string attackIs = attackChoices[fIndex];

        if(attackIs == "punch")
        {
            DamageAmount = 30;
            Target.Health -= DamageAmount;
        }
        if (attackIs == "kick")
        {
            DamageAmount = 25;
            Target.Health -= DamageAmount;
        }
        if (attackIs == "tackle")
        {
            DamageAmount = 35;
            Target.Health -= DamageAmount;
        }
        Console.WriteLine($"{attackIs} dealing {DamageAmount} damage reducing health by {Target.Health}!!");
    }

    public Melee(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 120;
        AttackList = new List<string>();
    }
}