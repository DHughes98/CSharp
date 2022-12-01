// Game Dev 1

// Attack Slash = new Attack("Slash", 10);

// Attack Headbutt = new Attack("Headbutt", 15);

// Attack BodySlam = new Attack("BodySlam", 20);

// Enemy Goblin = new Enemy("Goremond", 100);

// Goblin.attackList.Add(Slash);
// Goblin.attackList.Add(Headbutt);
// Goblin.attackList.Add(BodySlam);
// Goblin.RandomAttack();



// Game Dev 2
MeleeFighter MF = new MeleeFighter();
RangedFighter RF = new RangedFighter();
MageFighter MC = new MageFighter();

MF.DoAttack(RF);
RF.DoAttack(MF);
RF.Dash();
RF.DoAttack(MF);
MC.Heal(RF);
MC.DoAttack(MF);