class Enemy 
{
    string Name;
    int HP;
    List<Attack> attacks;


    public Enemy(string n, int HP)
    {
        Name = n;
        attacks = new List<Attack>();
    }



}