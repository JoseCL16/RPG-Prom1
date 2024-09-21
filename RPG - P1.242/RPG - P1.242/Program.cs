using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___P1._242
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Brunn, The barbarian");
            Wizard wizard = new Wizard("Percy, The old wizard");
            Rogue rogue = new Rogue("Vex, The forest rogue");

            Dragon dragon = new Dragon("Red Dragon");
            Golem golem = new Golem("Ore Golem");

            Console.WriteLine("Choose a character:");
            Console.WriteLine("1. Warrior - Health:100, Attack:40, Defense:10");
            Console.WriteLine("2. Wizard - Health:80, Attack:30, Defense:5");
            Console.WriteLine("3. Rogue - Health:70, Attack:25, Defense:15");
            int choiceCharacter = int.Parse(Console.ReadLine());

            Character player;
            if (choiceCharacter == 1)
            {
                player = warrior;
            }
            else if (choiceCharacter == 2)
            {
                player = wizard;
            }
            else
            {
                player = rogue;
            }

            Console.WriteLine($"You have choose {player.Name}.");

            Console.WriteLine("Choose a beast to slay:");
            Console.WriteLine("1. Dragon - Health:120, Attack:50, Defense:20");
            Console.WriteLine("2. Golem - Health:120, Attack:30, Defense:15");
            int choiceBeast = int.Parse(Console.ReadLine());

            Enemy beast;
            if (choiceBeast == 1)
            {
                beast = dragon;
            }
            else
            {
                beast = golem;
            }

            Console.WriteLine($"You have choose to fight the {beast.Name}.");

            Random random = new Random();
            bool keepFighting = true;

            while (keepFighting && player.Health > 0 && beast.Health > 0)
            {
                Console.WriteLine("Your Turn, what will you do?");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Special Skill");
                int choiceAction = int.Parse(Console.ReadLine());

                if (choiceAction == 1)
                {
                    player.Attack(beast);
                }
                else 
                {
                    player.SpecialSkill(beast);
                }

                if (beast.Health <= 0)
                {
                    Console.WriteLine($"{beast.Name} has been defeated. Victory!");
                    Console.WriteLine("Press ENTER to close program.");
                    Console.ReadKey();
                }

                int actionEnemy = random.Next(1, 3);
                Console.WriteLine($"{beast.Name}'s turn");
                if (actionEnemy == 1)
                {
                    beast.Attack(player);
                }
                else if (actionEnemy == 2)
                {
                    beast.Roar();
                }
                else
                {
                    beast.SpecialAttack();
                }

                if (player.Health <= 0)
                {
                    Console.WriteLine($"{player.Name} has perished. Game Over!");
                    Console.WriteLine("Press ENTER to close program.");
                    Console.ReadKey();

                }
            }
        }
    }
}
