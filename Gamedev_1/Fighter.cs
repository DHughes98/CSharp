class MeleeFighter : Enemy
{
    public MeleeFighter() : base("Orc", 120)
    {
        attackList.Add(new Attack("Punch", 20));
        attackList.Add(new Attack("Kick", 15));
        attackList.Add(new Attack("Tackle", 25));
    }
    void  SuperAttack(Enemy Target)
    {
       Attack superAttack = RandomAttack();
       Target.HP -= superAttack.Damage + 10;
       
       Console.WriteLine($"{Name} used {superAttack.Name} on {Target.Name} for {superAttack.Damage} HP");
       
    }
}