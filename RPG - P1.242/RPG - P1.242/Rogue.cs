using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___P1._242
{
    class Rogue : Character
    {
        public Rogue(string name) : base(name, 70, 25, 15)
        {
        }

        public override void SpecialSkill(Enemy opponent)
        {
            int alphaDamage = alphaAttack * 2;
            if (alphaDamage < 0) alphaDamage = 0;
            opponent.Health -= alphaDamage;
            if (opponent.Health <= 0) opponent.Health = 0;
            Console.WriteLine($"{Name} Throws Dagger Barrage, inflicting brutal damage");
            Console.WriteLine($"Warrior dealed {alphaDamage} damage");
            Console.WriteLine($"Beast life: {opponent.Health}");
        }

        public override void Attack(Enemy opponent)
        {
            int damage = alphaAttack - opponent.Defense;
            if (damage < 0) damage = 0;
            opponent.Health -= damage;
            if (opponent.Health <= 0) opponent.Health = 0;
            Console.WriteLine($"{Name} stabs {opponent.Name}, dealing {alphaAttack} points of damage");
            Console.WriteLine($"Rogue dealed {damage} damage");
            Console.WriteLine($"Beast life: {opponent.Health}");
        }
    }
}
