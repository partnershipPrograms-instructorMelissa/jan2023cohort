Enemy Player1 = new Enemy("Bandit");
Player1.AttackList.Add("fireball");
Player1.AttackList.Add("punch");
Player1.AttackList.Add("throw");
// Console.WriteLine(Player1.Health);

foreach(String Attack in Player1.AttackList)
    Console.WriteLine(Attack);
