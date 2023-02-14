class Enemy 
{
    public string Name;
    public int Health;
  
    public List<string> AttackList {get; set;}

    public void RandomAttack()
    {
        Random rnd = new Random();
   
        List<string> attackChoices = this.AttackList;

         int fIndex = rnd.Next(attackChoices.Count);

         Console.WriteLine("Your Attack is: {0}", attackChoices[fIndex]);
    }

    public Enemy(string name)
    {
        Name = name;
        Health = 100;
        AttackList = new List<string>();
    }

}