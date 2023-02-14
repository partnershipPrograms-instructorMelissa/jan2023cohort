class Enemy 
{
    public string Name;
    public int Health;
    public List<string> AttackList {get; set;}

    public Enemy(string name, int health, List<string> attackList)
    {
        Name = name;
        Health = 100;
        AttackList = new List<string>();
    }
}