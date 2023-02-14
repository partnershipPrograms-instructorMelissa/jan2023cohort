class Enemy 
{
    public string Name;
    public int Health;
  
    public List<string> AttackList {get; set;}

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<string>();
    }
}