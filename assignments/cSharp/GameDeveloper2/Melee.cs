public class Melee : Enemy
{
    public Melee(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 120;
        AttackList = new List<string>();
    }
}