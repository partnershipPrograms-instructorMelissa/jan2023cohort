class Enemy 
{
    public string EnemyName;
    private int Health;

    public List<string> AttackList { get; set; }

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

        List<string> attackChoices = AttackList;

        int fIndex = rnd.Next(attackChoices.Count);

        Console.WriteLine($"Your Attack is: {attackChoices[fIndex]}");
    }
    public Enemy(string enemyName) 
    {
        EnemyName = enemyName;
        Health = 100;
        AttackList = new List<string>();
    }

}