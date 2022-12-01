class Enemy 
{
    public string Name;
    public int HP;
    public List<Attack> attackList;


    public Enemy(string n, int Hp)
    {
        Name = n;
        HP = Hp;
        attackList = new List<Attack>();
        
    }

public virtual Attack RandomAttack()
{
    Random randomAttack = new Random();
    int index = randomAttack.Next(0,attackList.Count);
    
    return attackList[index];
    // Console.WriteLine($"Attack name: {attackList[index].Name}");
}

    public virtual void DoAttack(Enemy Target)
    {
        Attack randomAttack = RandomAttack();
        Target.HP -= randomAttack.Damage;
        Console.WriteLine($"{Name} used {randomAttack.Name} on {Target.Name} for {randomAttack.Damage} HP");
    }


}