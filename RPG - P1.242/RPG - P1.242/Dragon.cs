using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___P1._242
{
    class Dragon : Enemy
    {
        public Dragon (string name) : base (name, 120, 50, 20)
        {

        }

        public override void SpecialAttack()
        {
            Console.WriteLine($"{Name} Flies into the sky and comes down like a meteor, dealing a masive Blow");
        }

        public override void Attack(Character opponent)
        {
            int damage = alphaAttack - opponent.Defense;
            if (damage < 0) damage = 0;
            opponent.Health -= damage;
            if (opponent.Health <= 0) opponent.Health = 0;
            Console.WriteLine($"{Name} attacks with its claws and fire breath, inflicting {alphaAttack} points of damage.");
            Console.WriteLine($"Dragon dealed {damage} damage");
            Console.WriteLine($"Player life: {opponent.Health}");
        }
    }
}