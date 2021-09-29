using System;

namespace cd_c_rpg_group
{


    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligience;
        public int Dexterity;
        public int Health;

        // Add a public "getter" property to access health
        //public int Health
        //{
        //    get
        //    {
        //        return health;
        //    }
        //    set
        //    {
        //        health = value;
        //    }
        //}

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string Name)
        {
            Strength = 3;
            Intelligience = 3;
            Dexterity = 3;
            Health = 100;
            this.Name = Name;
        }

        // Add a constructor to assign custom vaues to all fields
        public Human(string Name, int Strength, int Intelligience, int Dexterity, int Health)
        {
            this.Strength = Strength;
            this.Intelligience = Intelligience;
            this.Dexterity = Dexterity;
            this.Health = Health;
            this.Name= Name;
        }

        // Build Attack method
        public virtual int Attack(Human target)
        {
            int damage = Strength * 5; 
            target.Health -= damage;
            System.Console.WriteLine($"{Name} attacked {target.Name}  for {damage} damage!");
            return target.Health;
        } // END ATTACK METHOD

    } // END HUMAN CLASS


}