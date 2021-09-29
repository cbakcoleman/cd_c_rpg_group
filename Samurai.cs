using System;

namespace cd_c_rpg_group
{
    class Samurai : Human
    {
        public Samurai(string Name, int Strength = 3, int Intelligience = 3, int Dexterity = 3, int Health = 200) : base(Name, Strength, Intelligience, Dexterity, Health)
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

        public virtual int Meditate(Samurai target)
        {
            target.Health = 200;
            return target.Health;
        } // END MEDITATE METHOD

    } // END SAMURAI CLASS

}