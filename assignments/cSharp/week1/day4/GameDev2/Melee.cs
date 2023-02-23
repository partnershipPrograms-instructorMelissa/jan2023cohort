class Melee : Enemy
{

  public Attack Punch = new Attack("Punch", 20);
  public Attack Kick = new Attack("Kick", 15);
  public Attack Tackle = new Attack("Tackle", 25);
  public Melee(string name) : base(name, 120)
  {
    base.AttackList.Add(Punch);
    base.AttackList.Add(Kick);
    base.AttackList.Add(Tackle);
  }

  public void Rage(Enemy target)
  {
    Attack randomAttack = base.RandomAttack();
    randomAttack.DamageAmount += 10;
    base.PerformAttack(target, randomAttack);
    randomAttack.DamageAmount -= 10;
  Console.WriteLine($"{base.Name} used Rage!");
  }
}