class MagicCaster : Enemy
{

  public Attack Fireball = new Attack("Fireball", 25);
  public Attack Lightning = new Attack("Lightning Bolt", 20);
  public Attack Staff = new Attack("Staff Strike", 10);
  public MagicCaster(string name) : base(name, 80)
  {
    base.AttackList.Add(Fireball);
    base.AttackList.Add(Lightning);
    base.AttackList.Add(Staff);
  }

  public void Heal(Enemy Target){
    Target.Health += 40;
    if(Target.Health > Target.MaxHealth) {
      Target.Health = Target.MaxHealth;
    }
    Console.WriteLine($"{base.Name} healed {Target.Name} to {Target.Health} health");
  }
}