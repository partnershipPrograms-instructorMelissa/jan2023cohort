class Enemy : Attack, RestartGame
{
    public string EnemyName;
    public int Health; 
    public string Target; 
    public List<Attack> AttackList; 
    public virtual Attack RandomAttack()
    {
        Random rnd = new Random();

        List<Attack> attackChoices = AttackList;

        int fIndex = rnd.Next(attackChoices.Count);

        return attackChoices[fIndex];
    }
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
      
        Target.Health -= ChosenAttack.DamageAmount;

        Console.WriteLine($"{EnemyName} attacks {Target.EnemyName}, dealing {ChosenAttack.DamageAmount} damage {ChosenAttack.AttackName} and reducing {Target.EnemyName}'s health to {Target.Health}!!");

    }
    public string StartGame()
    {
        Console.WriteLine("Welcome! Please enter your player name: ");
        this.EnemyName = Console.ReadLine();
        Console.WriteLine($"Your player name is {this.EnemyName}");
        this.Health = 100;
        return this.EnemyName;
    }
    public virtual int PlayGame(Enemy Target, Attack ChosenAttack)
    {
        if(this.Health != 0)
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

    public virtual void RePlay()
    {
        Console.WriteLine($"Would you like to play again? Enter (yes) to start or (no) to end the game!");

        string inputLine = Console.ReadLine();
        if (inputLine == "yes")
        {
            StartGame();
        }
        else if (inputLine == "no")
        {
            Console.WriteLine("Thanks for playing!");
        }
    }
    public Enemy(string enemyName, string attackName, int damageAmount) : base(attackName, damageAmount)
    {
        EnemyName = enemyName;
        Health = 100;
        AttackList = new List<Attack>()
        {
            new Attack("fireball", 25),
            new Attack("punch", 20),
            new Attack("throw", 15)
        };
        Target = "Sam";
    }
}