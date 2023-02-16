class Magic : Enemy
{
    public void HealMethod(Enemy Target)
    {
        int targetEnemy = Target.Health;
        



    }
    public Magic(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 80;
        AttackList = new List<string>();
    }
}