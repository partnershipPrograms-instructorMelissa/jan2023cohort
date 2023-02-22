class Melee : Enemy
{

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        base.PerformAttack(Target, ChosenAttack);
    }
    public void RageMethod(Enemy Target)
    {
        Attack rage = base.RandomAttack();
        rage.DamageAmount += 10;

        Console.WriteLine($"{EnemyName} attacks {Target.EnemyName}, dealing {rage.DamageAmount} damage {rage.AttackName} and reducing {Target.EnemyName}'s health to {Target.Health}!!");
    }

    public Melee(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 120;
        AttackList = new List<Attack>()
        {
            new Attack("punch", 20),
            new Attack("kick", 15),
            new Attack("tackle", 25)

        };
    }
}