using System;

namespace cd_c_wizNinjSam
{
    class Ninja : Human
    {
        public Ninja(string Name, int Strength, int Intelligience, int Dexterity, int Health) : base(Name, Strength, Intelligience, 175, Health)
        {
            this.Name = Name;
        } // END NINJA CONSTRUCTOR

        public override int Attack(Human target)
        {
            Random rando = new Random(0, 21);
            int damage = Dexterity * 5; 
            int xtradmg = rando.Next(0, 21)
            target.Health -= damage;
            if (xtradmg == 20)
            {
                target.Health -= 10;
            }
            System.Console.WriteLine($"{Name} attacked {target.Name}  for {damage} damage!");
            return target.Health;
            
        } // END ATTACK METHOD

    } // END NINJA CLASS
}