using System;
using System.Collections.Generic;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bob = new Human("bob", 3, 90, 3, 100);//this ording has to match the construction function parrameters.
            Human joe = new Human("joe", 3, 90, 3, 100);//this ording has to match the construction function parrameters.
            System.Console.WriteLine(bob.Name);
            System.Console.WriteLine(joe.Name);
            System.Console.WriteLine(bob.Strength);
            System.Console.WriteLine(bob.Intelligence);
            System.Console.WriteLine(bob.Dexterity);
            System.Console.WriteLine(bob.health);//note private field has a different name in this case lowercase
            bob.Attack(joe);
            System.Console.WriteLine(joe.health);
            joe.TakeDmg(10);
            joe.Attack(bob);
            System.Console.WriteLine(bob.health);
            System.Console.WriteLine(joe.health);
        
        }
        class Human
        {
            // Fields for Human
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int Health;

            public int health
            {
                get { return Health; }
            }
            //get 
            public Human(string firstName, int str, int iq, int dex, int hp)
            {
                //construction human object with default values applied in line 10 as parrameters.... 
                Name = firstName;
                Strength = str;
                Intelligence = iq;
                Dexterity = dex;
                Health = hp;


            }
            public int Attack(Human target)
            {
                if (target is Human)
                {
                    int dmg = 5 * Strength;
                    target.Health -= dmg;
                    Console.WriteLine($"{Name} attack {target.Name}");
                    return target.Health;
                }
                else
                {
                    throw new Exception("Attack");
                }
            }

            public int TakeDmg(int dmg)
            {
                Health -= dmg;
                Console.WriteLine($"{Name} fell down");
                return Health;
            }
        
        }
    }
}