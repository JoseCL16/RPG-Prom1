using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___P1._242
{
    class Golem : Enemy
    {
        public Golem(string name) : base(name, 120, 30, 15)
        {

        }

        public override void SpecialAttack()
        {
            Console.WriteLine($"{Name} hits the ground, shaking it, stunning everyone around");
        }

        public override void Attack(Character opponent)
        {
            int damage = alphaAttack - opponent.Defense;
            if (damage < 0) damage = 0;
            opponent.Health -= damage;
            if (opponent.Health <= 0) opponent.Health = 0;
            Console.WriteLine($"{Name} throws a punch, inflicting {alphaAttack} points of damage");
            Console.WriteLine($"Golem dealed {damage} damage");
            Console.WriteLine($"Player life: {opponent.Health}");
        }
    }
}
