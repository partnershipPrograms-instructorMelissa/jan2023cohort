// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Melee Penguin = new Melee("The Penguin");
Ranged Rag = new Ranged("Ra's al Ghul");
MagicCaster Poison = new MagicCaster("Poison Ivy");

// Penguin.PerformAttack(Rag, Penguin.AttackList[1]);
// Penguin.PerformAttack(Rag, Penguin.AttackList[2]);
Penguin.Rage(Poison);
// Rag.PerformAttack(Penguin, Rag.AttackList[0]);
// Rag.Dash();
// Rag.PerformAttack(Penguin, Rag.AttackList[0]);
// Poison.PerformAttack(Penguin, Poison.AttackList[0]);
// Poison.Heal(Rag);
Poison.Heal(Poison);