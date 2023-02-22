Enemy player1 = new Enemy("Bandit", "throw", 15);
Attack Player2 = new Attack("Punch", 20);
// Console.WriteLine(Player1._Health);


Melee attack = new Melee("Paul","kick", 25);
Melee attack1 = new Melee("Sara","punch", 5);
Melee attack2 = new Melee("Saul","tackle", 20);

Melee Kicker = new Melee("Paul", "kick", 25);

Melee player3 = new Melee("Sam", "fireball", 25);
Melee player6 = new Melee("Bob", "fireball", 25);

// player3.AttackList.Add(attack);
// player3.AttackList.Add(attack1);
// player3.AttackList.Add(attack2);
// player3.Target = "Ranged Character";
// Console.WriteLine(player3.Target);

player3.RandomAttack();

Ranged player4 = new Ranged("Sue", "arrow", 20);
// player4.PerformAttack();
// player4.DashMethod();

Magic player5 = new Magic("Sarah", "fireball", 25);
// player5.HealMethod(player3);

// Console.WriteLine(player4.Health);
// Kicker.PerformAttack(player4, attack);
// player4.PerformAttack(player3, attack2);
// player3.RageMethod(player5);
player4.DashMethod();
// player4.PerformAttack(player3, attack1);
// player5.PerformAttack(player3, attack);
// player5.HealMethod(player4);
// player5.HealMethod(player5);

Player newPlayer = new Player();

// newPlayer.startGame();

// newPlayer.EnemyChosen();


newPlayer.PlayGame(player1, attack2);
player1.PlayGame(newPlayer, attack1);
newPlayer.PlayGame(player1, attack2);
player1.PlayGame(newPlayer, attack1);
newPlayer.PlayGame(player1, attack2);
player1.PlayGame(newPlayer, attack1);
newPlayer.PlayGame(player1, attack2);
player1.PlayGame(newPlayer, attack1);
newPlayer.PlayGame(player1, attack2);
player1.PlayGame(newPlayer, attack1);
newPlayer.PlayGame(player1, attack2);
player1.PlayGame(newPlayer, attack1);

















