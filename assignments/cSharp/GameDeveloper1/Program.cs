Enemy Ogre = new Enemy("Ogre");

Attack ogreAttack = new Attack("Spit ball", 5);
Ogre.AddAttack(ogreAttack);
ogreAttack = new Attack("Throw Rock", 9);
Ogre.AddAttack(ogreAttack);
ogreAttack = new Attack("Stomp Ground", 7);

Ogre.RandomAttack();