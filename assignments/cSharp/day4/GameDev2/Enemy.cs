//* Enemy Class

class Enemy
{
  public string Name;
  public int Health;
  public int MaxHealth;
  public List<Attack> AttackList;
  public Enemy(string name)
  {
    Name = name;
    Health = 100;
    MaxHealth = Health;
    AttackList = new List<Attack>();
  }

  public Enemy(string name, int maxHealth)
  {
    Name = name;
    Health = maxHealth;
    MaxHealth = Health;
    AttackList = new List<Attack>();
  }

  public Attack RandomAttack()
  {
    Random rand = new Random();
    int indexRand = rand.Next(AttackList.Count);
    return AttackList[indexRand];
    // Console.WriteLine($"{Name} used {AttackList[indexRand].Name}! Watch out!");
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

  // static Attack GetListItem(List<Attack> AttackList, int selectedIndex)
  // {
  //   if (selectedIndex >= 0 && selectedIndex < AttackList.Count)
  //   {
  //     // Console.WriteLine(AttackList[selectedIndex]);
  //     return AttackList[selectedIndex];
  //   }
  // }


  // Inside of the Enemy class
  public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
  {
    // Random rand = new ();
    // int attack = rand.Next(AttackList.Count);
    // for (int i = 0; i < AttackList.Count; i++)
    // foreach(Attack singleAttack in AttackList); 


    // Write some logic here to reduce the Targets health by your Attack's DamageAmount
    if (Health > 0 && Target.Health > 0)
    {
      Target.Health -= ChosenAttack.DamageAmount;
      if (Target.Health < 0)
      {
        Target.Health = 0;
      }
      Console.WriteLine($"{Name} attacks {Target.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }
    else if (Health <= 0)
    {
      Console.WriteLine($"{Name}'s health is {Health}! They are too hurt to attack!");
    }
    else
    {
      Console.WriteLine($"{Name}'s health is {Health}. They're dead, please stop...");
    }
  }
}