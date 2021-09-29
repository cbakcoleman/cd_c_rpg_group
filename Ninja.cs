using System;

namespace cd_c_rpg_group
{
    class Ninja : Human
    {
        public Ninja(string Name, int Strength = 3, int Intelligience = 3, int Dexterity = 175, int Health = 100) : base(Name, Strength, Intelligience, Dexterity, Health)
        {
            this.Name = Name;
        } // END NINJA CONSTRUCTOR

        public override int Attack(Human target)
        {
            Random rando = new Random();
            int damage = Dexterity * 5; 
            int xtradmg = rando.Next(0, 21);
            target.Health -= damage;
            if (xtradmg == 20)
            {
                target.Health -= 10;
            }
            System.Console.WriteLine($"{Name} attacked {target.Name}  for {damage} damage!");
            return target.Health;
            
        } // END ATTACK METHOD

        public virtual int Steal(Human target)
        {
            target.Health -= 5;
            this.Health += 5;
            return target.Health;
        } // END STEAL METHOD

    } // END NINJA CLASS
}