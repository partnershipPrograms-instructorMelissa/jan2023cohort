public class Enemy {
    string Name;
    private int Health;
    private List<Attack> AttackList;

    public Enemy(string name){
        Name = name;
        Health = 100;
        AttackList = new List<Attack>();
    }

    public void RandomAttack(){
        Random rand = new Random();
        int indexMax = AttackList.Count;

        if(indexMax == 0){
            Console.WriteLine($"Enemy cowers in fear as they have no attack");
        }
        else{
            Attack attack = AttackList[rand.Next(indexMax)];
            Console.WriteLine($"Enemy uses {attack.Name} to attack for {attack.DamageAmount}");
        }
    }

    public void AddAttack(Attack attack){
        AttackList.Add(attack);
    }

    public int GetHealth(){
        return Health;
    }
}   