class Enemy 
{
    string Name;
    int HP;
    public List<Attack> attackList;


    public Enemy(string n, int Hp)
    {
        Name = n;
        HP = Hp;
        attackList = new List<Attack>();
        
    }

public void RandomAttack()
{
    Random randomAttack = new Random();
    int index = randomAttack.Next(0,attackList.Count);
    Console.WriteLine($"Attack name: {attackList[index].Name}");
}


}