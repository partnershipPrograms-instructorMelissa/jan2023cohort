class Enemy {
    public string Name;
    private int Health;
    public List<Attack> AttackList;
    public Random rand;

    public Enemy(string name){
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
        rand = new Random();
    }
    public Enemy(string name, int health){
        Name = name;
        Health = health;
        AttackList = new List<Attack>();
        rand = new Random();
    }
    public Attack RandomAttack(){
        Attack attack = new Attack("", 0);

        int indexMax = AttackList.Count;
        if(indexMax == 0){
            Console.WriteLine($"Enemy cowers, as they have no attack");
        }
        else{
            attack = AttackList[rand.Next(indexMax)];
        }
        return attack;
    }
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.ChangeHealth(ChosenAttack.DamageAmount);
        // Write some logic here to reduce the Targets health by your Attack's DamageAmount
        Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }

    public void ChangeHealth(int value){
        Health -= value;
    }

    public int GetHealth(){
        return Health;
    }

    public void AddAttack(Attack attack){
        AttackList.Add(attack);
    }

}   