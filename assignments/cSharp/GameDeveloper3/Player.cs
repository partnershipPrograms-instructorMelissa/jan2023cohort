class Player : Enemy
{
    public string Name;

    public Player() : base("Sam", "punch", 15)
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
    }
    public string startGame()
    {
        Console.WriteLine("Welcome! Please enter your player name: ");
        this.Name = Console.ReadLine();
        Console.WriteLine($"Your player name is {this.Name}");
        return this.Name;  
    }
}