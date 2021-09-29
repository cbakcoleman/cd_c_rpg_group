using System;

namespace cd_c_wizNinjSam
{
    class Samurai : Human
    {
        public Samurai(string Name, int Strength, int Intelligience, int Dexterity, int Health) : base(Name, Strength, Intelligience, Dexterity, 200)
        {
            this.Name = Name;
        } // END SAMURAI CONSTRUCTOR

         public override int Attack(Human target)
        {
            int damage = Strength * 5; 
            if (target.Health <= 50)
            {
                target.Health = 0;
                System.Console.WriteLine($"{Name} has annihilated {target.Name} for TOTAL damage!");
            }
            else 
            {
                target.Health -= damage;
                System.Console.WriteLine($"{Name} attacked {target.Name}  for {damage} damage!");
            }
            
            return target.Health;
        } // END ATTACK METHOD

    } // END SAMURAI CLASS

}