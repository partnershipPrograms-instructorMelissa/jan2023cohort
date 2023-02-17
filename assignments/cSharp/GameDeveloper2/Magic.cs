class Magic : Enemy
{
    public int Heal;
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        base.PerformAttack(Target, ChosenAttack);
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
        AttackList = new List<Attack>()
        {
            new Attack("fireball", 25),
            new Attack("lighting", 20),
            new Attack("staff strike", 10)

        };
    }
}