

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
            base.PerformAttack(Target, ChosenAttack);
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
        AttackList = new List<Attack>()
        {
            new Attack("arrow", 20),
            new Attack("knife", 15)
         };
    }
}