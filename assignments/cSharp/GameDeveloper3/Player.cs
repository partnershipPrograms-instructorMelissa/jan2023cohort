class Player : Enemy
{
    public string Name;
    public List<Melee> EnemyList;
    public string startGame()
    {
        Console.WriteLine("Welcome! Please enter your player name: ");
        this.Name = Console.ReadLine();
        Console.WriteLine($"Your player name is {this.Name}");
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
    public Player() : base("Susan", "punch", 15)
    {
        Name = Name;
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