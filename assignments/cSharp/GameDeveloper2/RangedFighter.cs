class RangedFighter: Enemy {
    int Distance;
    public RangedFighter(string name): base(name){
        AttackList = new List<Attack>(){
            new Attack("Shoot an Arrow", 20),
            new Attack("Throw a Knife", 15)
        };
    }

    public void Dash(){
        Distance = 20;

        Console.WriteLine($"{Name} dashes away.");
    }

    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if(Distance > 9){
            base.PerformAttack(Target, ChosenAttack);
        }
        else {
            Console.WriteLine($"{Name} cannot perform attack, enemy is too close");
        }
    }
}