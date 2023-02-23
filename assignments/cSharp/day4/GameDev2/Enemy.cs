//* Enemy Class

class Enemy
{
  public string Name;
  private int Health;
  public List<Attack> AttackList;

  public Enemy(string name)
  {
    Name = name;
    Health = 100;
    AttackList = new List<Attack>();
  }

  public void RandomAttack()
  {
    Random rand = new Random();
    int attack = rand.Next(AttackList.Count);
    Console.WriteLine($"{Name} used {AttackList[attack].Name}! Watch out!");
  }

  public int GetHealth()
  {
    return Health;
  }

  public void NewAttack(Attack newAttack)
  {
    AttackList.Add(newAttack);
    Console.WriteLine($"{Name} just learned {newAttack.Name}!");
  }

  // Inside of the Enemy class
  public void PerformAttack(Enemy Target, Attack ChosenAttack)
  {
    // Write some logic here to reduce the Targets health by your Attack's DamageAmount
    Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
  }

}