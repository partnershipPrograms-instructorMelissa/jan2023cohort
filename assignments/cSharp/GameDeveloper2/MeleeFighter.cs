class MeleeFighter: Enemy {
    public MeleeFighter(string name): base(name, 120){
        AttackList = new List<Attack>() {
            new Attack("Punch", 20),
            new Attack("Kick", 15),
            new Attack("Tackle", 25)
        };
    }
    public void Rage(Enemy enemy){
        Attack attack = RandomAttack();
        attack.DamageAmount += 10;

        PerformAttack(enemy, attack);
    }

}

// List<int> temp = new List<int>();

// temp.Add(5);

// temp[0];