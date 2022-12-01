class MageFighter : Enemy
{
    public MageFighter() : base ("Wizard", 80)
    {
        attackList.Add(new Attack("Fireball", 25));
        attackList.Add(new Attack("Shield", 0));
        attackList.Add(new Attack("Staff Strike", 15));
    }

     public void Heal(Enemy Target)
    {
        Target.DmgTaken -= 40;
        if (Target.DmgTaken < 0)
        {
            Target.DmgTaken = 0;
            
        }
            Console.WriteLine($"{Name} healed {Target.Name} and {Target.Name}'s HP is {Target.HP}");
    }
}