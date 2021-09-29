using System;

namespace cd_c_wizNinjSam
{
    class Wizard : Human
    {
        public Wizard(string Name, int Strength, int Intelligience, int Dexterity, int Health) : base(Name, Strength, 25, Dexterity, 50)
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

    } // END WIZARD CLASS

}