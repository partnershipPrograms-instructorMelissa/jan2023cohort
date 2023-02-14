Attack attack = new Attack("fireball", 25);
Attack attack1 = new Attack("punch", 5);
Attack attack2 = new Attack("throw", 20);


Enemy Player1 = new Enemy("Bandit");
Player1.AttackList.Add(attack.Name);
Player1.AttackList.Add(attack1.Name);
Player1.AttackList.Add(attack2.Name);
Console.WriteLine(Player1.Health);

foreach(String Attack in Player1.AttackList)
{
    Console.WriteLine(Attack);
}

Player1.RandomAttack();



