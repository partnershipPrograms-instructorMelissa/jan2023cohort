class Enemy 
{
    public string Name;
    private int Health;
  
    public List<string> AttackList {get; set;}

    public int _Health
    {
        get
        {
            return Health;
        }
    }

    public void RandomAttack()
    {
        Random rnd = new Random();
   
        List<string> attackChoices = this.AttackList;

        int fIndex = rnd.Next(attackChoices.Count);

        Console.WriteLine($"Your Attack is: {attackChoices[fIndex]}");
    }

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<string>();
    }

}