class Ranged : Enemy
{
    public int Distance;


    public Ranged(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        Distance = 5;
    }
}