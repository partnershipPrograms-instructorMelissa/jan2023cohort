Enemy Player1 = new Enemy("Bandit", "throw", 15);
Attack Player2 = new Attack("Punch", 20);
// Console.WriteLine(Player1._Health);

// Player1.PerformAttack();

Melee attack = new Melee("Paul","kick", 25);
Melee attack1 = new Melee("Sara","punch", 5);
Melee attack2 = new Melee("Saul","tackle", 20);

Melee player3 = new Melee("Sam", "fireball", 25);

player3.AttackList.Add(attack.AttackName);
player3.AttackList.Add(attack1.AttackName);
player3.AttackList.Add(attack2.AttackName);

// foreach(String Attack in player3.AttackList)
// {
//     Console.WriteLine(Attack);
// }

// player3.RandomAttack();

Ranged player4 = new Ranged("Sue", "arrow", 20);
player4.PerformAttack();












