class Attack
{
    public string AttackName;
    public int DamageAmount;
    public string Target; 

    public Attack(string attackName, int damageAmount, string target)
    {
        AttackName = attackName;
        DamageAmount = damageAmount;
        Target = target;
    }
}