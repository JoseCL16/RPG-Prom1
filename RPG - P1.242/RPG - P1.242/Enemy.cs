using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___P1._242
{
    public abstract class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int alphaAttack { get; set; }
        public int Defense { get; set; }


        public Enemy(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            alphaAttack = attack;
            Defense = defense;
        }

        public abstract void SpecialAttack();

        public void Roar()
        {
            Console.WriteLine($"{Name} roars loudly intimidating his opponents");
        }
        public virtual void Attack(Character opponent)
        {
            int damage = alphaAttack - opponent.Defense;
            if (damage < 0) damage = 0;
            opponent.Health -= damage;
            if (opponent.Health <= 0) opponent.Health = 0;
            Console.WriteLine(damage);
            Console.WriteLine(opponent.Health);
            Console.WriteLine($"{Name} attack with {alphaAttack} points of damage");
        }
    }
}
