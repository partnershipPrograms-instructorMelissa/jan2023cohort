

class Ranged : Enemy
{
    public int Distance;
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (this.Distance < 10)
        {
            Console.WriteLine($"Cannot perform attack! Your distance is too low. Current distance is {this.Distance}");

        }
        else
        {
            if (ChosenAttack.AttackName == "arrow")
            {
                DamageAmount = 20;
                Target.Health -= DamageAmount;
            }
            if (ChosenAttack.AttackName == "knife")
            {
                DamageAmount = 15;
                Target.Health -= DamageAmount;
            }
            Console.WriteLine($"{EnemyName} dealt {DamageAmount} damage {ChosenAttack.AttackName} to {Target.EnemyName} reducing health to {Target.Health}!!");
        }
    }

    public void DashMethod()
    {

        this.Distance = 20;

        Console.WriteLine($"You now have a distance of {this.Distance}");
    }

    public Ranged(string enemyName, string attackName, int damageAmount) : base(enemyName, attackName, damageAmount)
    {
        Distance = 5;
    }
}