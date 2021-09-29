using System;

namespace cd_c_rpg_group
{
    class Wizard : Human
    {
        public Wizard(string Name, int Strength = 3, int Intelligience = 25, int Dexterity = 3, int Health = 50) : base(Name, Strength, Intelligience, Dexterity, Health)
        {
            this.Name = Name;
        } // END WIZARD CONSTRUCTOR

        public override int Attack(Human target)
        {
            int damage = Intelligience* 5; 
            target.Health -= damage;
            this.Health += damage;
            System.Console.WriteLine($"{Name} attacked {target.Name}  for {damage} damage!");
            return target.Health;
            
        } // END ATTACK METHOD

        public virtual int Heal(Human target)
        {
            int healing = Intelligience * 3;
            target.Health += healing;
            System.Console.WriteLine($"{Name} healed {target.Name}  for {healing} health");
            return target.Health;
        } // END HEAL METHOD

    } // END WIZARD CLASS

}