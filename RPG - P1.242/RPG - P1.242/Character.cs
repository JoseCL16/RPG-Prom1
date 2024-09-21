using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___P1._242
{
    public abstract class Character : IActions
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int alphaAttack { get; set; }
        public int Defense { get; set; }

        public Character(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            alphaAttack = attack;
            Defense = defense;
        }

        public virtual void SpecialSkill(Enemy opponent)
        {
            int alphaDamage = alphaAttack * 2;
            if (alphaDamage< 0) alphaDamage = 0;
            opponent.Health -= alphaDamage;
            Console.WriteLine(alphaDamage);
            Console.WriteLine($"{Name} attack with {alphaAttack} points of damage");
        }

        public virtual void Attack(Enemy opponent)
        {
            int damage = alphaAttack - opponent.Defense;
            if (damage < 0) damage = 0;
            opponent.Health -= damage;
            Console.WriteLine(damage);
            Console.WriteLine($"{Name} attack with {alphaAttack} points of damage");
        }
    }
}
