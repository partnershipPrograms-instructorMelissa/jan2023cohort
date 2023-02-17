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