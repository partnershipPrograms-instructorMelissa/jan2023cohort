class Enemy {
    string Name;
    int Health;
    public List<Attack> AttackList;

    public Enemy(string n){
        Name = n;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public Attack Fetch(){
        Random rand = new Random();
        int RandomAttack = rand.Next(AttackList.Count);
        Console.WriteLine(RandomAttack);
        return AttackList[RandomAttack];
    }

}
