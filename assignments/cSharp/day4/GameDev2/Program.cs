// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Enemy Scarecrow = new Enemy("Scarecrow");
Attack Gas = new Attack("Fear Gas", 25);
Attack Needle = new Attack("Poison Shot", 15);
Attack Scythe = new Attack("Scythe Swipe", 10);

Scarecrow.NewAttack(Gas);
Scarecrow.NewAttack(Needle);
Scarecrow.NewAttack(Scythe);

Scarecrow.RandomAttack();