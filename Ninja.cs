using System;

namespace cd_c_rpg_group
{
    class Ninja : Human
    {
        public Ninja(string Name) : base(Name, 3, 3, 175, 100)
        {
            this.Name = Name;
        } // END NINJA CONSTRUCTOR

        public override int Attack(Human target)
        {
            Random rando = new Random();
            int damage = Dexterity * 5; 
            int xtradmg = rando.Next(0, 6);
            target.Health -= damage;
            if (xtradmg == 5)
            {
                target.Health -= 10;
            }
            System.Console.WriteLine($"{Name} attacked {target.Name}  for {damage} damage AND {xtradmg} EXTRA DAMAGE!");
            return target.Health;
            
        } // END ATTACK METHOD

        public int Steal(Human target)
        {
            target.Health -= 5;
            this.Health += 5;
            System.Console.WriteLine($"{Name} stole 5 HP from {target.Name}!");
            return target.Health;
        } // END STEAL METHOD

    } // END NINJA CLASS
}