// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Attack MyAttack1 = new Attack("Fireball", 20);
Attack MyAttack2 = new Attack("Punch", 7);
Attack MyAttack3 = new Attack("Kick", 13);

Enemy Enemy1 = new Enemy("Joslyn");

Enemy1.AttackList.Add(MyAttack1);
Enemy1.AttackList.Add(MyAttack2);
Enemy1.AttackList.Add(MyAttack3);
// Console.WriteLine(Enemy1.AttackList[0].Name);
// Console.WriteLine(Enemy1.AttackList[1].Name);
// Console.WriteLine(Enemy1.AttackList[2].Name);

Enemy1.Fetch();