class RangedFighter : Enemy
{

    public int distance;
    public RangedFighter() : base("Archer", 100)
    {
        distance = 5;
        attackList.Add(new Attack("Shoot an Arrow", 20));
        attackList.Add(new Attack("Throw a Knife", 15));
        if (distance < 10)
        {
            Console.WriteLine($"{Name} is to close use Dash");
        }

        void Dash()
        {
            distance = 20;
            Console.WriteLine($"{Name} used dash distance is now {distance}");
        }
    }

}
