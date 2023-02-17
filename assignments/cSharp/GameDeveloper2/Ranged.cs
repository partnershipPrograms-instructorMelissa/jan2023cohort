class Ranged : Enemy
{
    public int Distance;
    public int Dash;
    public override void PerformAttack(Enemy Target)
    {
        

        if(this.Distance < 10)
        {
            Console.WriteLine($"Cannot perform attack! Your distance is too low. Current distance is {this.Distance}");
            
        } else {
            if (AttackName == "arrow")
            {
                DamageAmount = 20;
                Target.Health -= DamageAmount;
            }
            if (AttackName == "knife")
            {
                DamageAmount = 15;
                Target.Health -= DamageAmount;
            }
            Console.WriteLine($"{EnemyName} dealt {DamageAmount} damage {AttackName} to {Target} reducing health to {Target.Health}!!");
        }
    }

    public void DashMethod()
    {
      
        this.Distance += this.Dash;

        Console.WriteLine($"Your dash amount is {this.Dash}, you now have a distance of {this.Distance}");  
    }

    public Ranged(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        Distance = 5;
        Dash = 20;
    }
}