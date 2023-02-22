class Player : Enemy, RestartGame
{
    public string Name;
    public List<Melee> EnemyList;
    public string StartGame()
    {
        Console.WriteLine("Welcome! Please enter your player name: ");
        this.Name = Console.ReadLine();
        Console.WriteLine($"Your player name is {this.Name}");
        this.Health = 100;
        return this.Name;
    }
    public Melee RandomEnemy()
    {
        Random rnd = new Random();

        List<Melee> enemyChoices = EnemyList;

        int eIndex = rnd.Next(enemyChoices.Count);

        Console.WriteLine(enemyChoices[eIndex]);

        return enemyChoices[eIndex];
    }
    public void EnemyChosen()
    {
        Melee rage = RandomEnemy();
        rage.Health -= rage.DamageAmount;

        Console.WriteLine($"{EnemyName} attacks {rage.EnemyName}, dealing {rage.DamageAmount} damage {rage.AttackName} and reducing {rage.EnemyName}'s health to {rage.Health}!!");
    }
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        base.PerformAttack(Target, ChosenAttack);

        // Console.WriteLine($"{EnemyName} attacks {Target.EnemyName}, dealing {ChosenAttack.DamageAmount} damage {ChosenAttack.AttackName} and reducing {Target.EnemyName}'s health to {Target.Health}!!");
    }

    public override int PlayGame(Enemy Target, Attack ChosenAttack)
    {
        if (this.Health != 0)
        {
            PerformAttack(Target, ChosenAttack);
        }
        else
        {
            Console.WriteLine($"Gameover! Your current health is {this.Health} which is too low to fight! {Target.EnemyName} won! ");

            RePlay();
        }
        return Target.Health;
    }

    public override void RePlay()
    {
        Console.WriteLine($"Would you like to play again? Enter (yes) to start or (no) to end the game!");
       
        string inputLine = Console.ReadLine();
        if(inputLine == "yes")
        {
            StartGame();
        }
        else if(inputLine == "no")
        {
            Console.WriteLine("Thanks for playing!");    
        }       
    }
    public Player() : base("Susan", "punch", 15)
    {
        Name = "Harry Potter";
        Health = 100;
        AttackList = new List<Attack>()
        {
            new Attack("smash", 25),
            new Attack("speed kick", 20),
            new Attack("boomerang", 10),
            new Attack("speed punch",15)
        };
        EnemyList = new List<Melee>()
        {
            new Melee("Keith", "kick", 20),
            new Melee("randall", "punch", 20),
            new Melee("Seth", "fireball", 25),
        };
    }
}