class MagicCaster: Enemy {
    public MagicCaster(string name): base(name, 80){
        AttackList = new List<Attack>(){
            new Attack("Fireball", 25),
            new Attack("Lightning Bolt", 20),
            new Attack("Staff Strike", 10)
        };
    }

    public void Heal(Enemy enemy){
        Attack heal = new Attack("Heal", -40);
        PerformHeal(enemy, heal);
    }

    public void PerformHeal(Enemy Target, Attack ChosenAttack)
    {
        Target.ChangeHealth(ChosenAttack.DamageAmount);

        Console.WriteLine($"{Name} heals {Target.Name} for {-ChosenAttack.DamageAmount} hp. {Target.Name} health is now {Target.GetHealth()}.");
    }
}