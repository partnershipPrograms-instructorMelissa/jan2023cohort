//  1.
MeleeFighter John = new MeleeFighter("John");

RangedFighter Jacob = new RangedFighter("Jacob");

MagicCaster JHS = new MagicCaster("Jingleheimer Schmidt");

// 2.
John.PerformAttack(Jacob, John.AttackList[1]);

// 3. 
John.Rage(JHS);

// 4. 
Jacob.PerformAttack(John, Jacob.AttackList[0]);

// 5. 
Jacob.Dash();

// 6. 
Jacob.PerformAttack(John, Jacob.AttackList[0]);

// 7. 
JHS.PerformAttack(John, JHS.AttackList[0]);

// 8. 
JHS.Heal(Jacob);

// 9. 
JHS.Heal(JHS);
