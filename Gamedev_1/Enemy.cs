class Enemy 
{
    public string Name;
    private int _HP;
    public int HP {get{return _HP - DmgTaken;}}
    public int DmgTaken;
    public List<Attack> attackList;


    public Enemy(string n, int Hp)
    {
        Name = n;
        _HP = Hp;
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
        Target.DmgTaken += randomAttack.Damage;
        Console.WriteLine($"{Name} used {randomAttack.Name} on {Target.Name} for {randomAttack.Damage} HP");
    }


}