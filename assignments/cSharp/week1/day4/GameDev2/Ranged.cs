class Ranged : Enemy
{
  int Distance;
  public Attack Arrow = new Attack("Arrow shot", 20);
  public Attack Knife = new Attack("Knife throw", 15);
  public Ranged(string name) : base(name)
  {
    Distance = 5;
    base.AttackList.Add(Arrow);
    base.AttackList.Add(Knife);
  }

  public override void PerformAttack(Enemy Target, Attack ChosenAttack)
  {
    if (Distance < 10)
    {
      Console.WriteLine($"{base.Name} is too far to attack.");
    }
    else
    {
      base.PerformAttack(Target, ChosenAttack);
    }
  }

  public void Dash()
  {
    Distance = 20;
    Console.WriteLine($"{base.Name} dashed forward!");
  }
}
