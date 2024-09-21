using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___P1._242
{
    class Wizard : Character
    {
        public Wizard (string name) : base(name, 80, 30, 5)
        {
        }

        public override void SpecialSkill(Enemy opponent)
        {
            int alphaDamage = alphaAttack * 2;
            if (alphaDamage < 0) alphaDamage = 0;
            opponent.Health -= alphaDamage;
            if (opponent.Health <= 0) opponent.Health = 0;
            Console.WriteLine($"{Name} throws a Fire Ball, inflicting brutal magic damage");
            Console.WriteLine($"Warrior dealed {alphaDamage} damage");
            Console.WriteLine($"Beast life: {opponent.Health}");
        }

        public override void Attack(Enemy opponent)
        {
            int damage = alphaAttack - opponent.Defense;
            if (damage < 0) damage = 0;
            opponent.Health -= damage;
            if (opponent.Health <= 0) opponent.Health = 0;
            Console.WriteLine($"{Name} casts a spell, dealing {alphaAttack} points of magic damage");
            Console.WriteLine($"Wizard dealed {damage} damage");
            Console.WriteLine($"Beast life: {opponent.Health}");
        }
    }
}
