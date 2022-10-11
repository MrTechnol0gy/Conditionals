using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    internal class Program
    {
        static int health;
        static int enemydamage;
        static bool loopend;
        static int weapon;
        static int healthboost;

        static void Main(string[] args)
        {
            Console.WriteLine("Conditionals.");
            Console.WriteLine("------------------");
            Console.WriteLine();

            health = 100;
            enemydamage = 10;
            weapon = 0;
            loopend = false;
            healthboost = 3;

            while (loopend == false)
            {
            TakeDamage(enemydamage);
            ShowHud();            
            }
            
            Console.ReadKey(true);
        }

        static void TakeDamage(int damage)
        {
            Console.WriteLine("Player is about to take " + damage + " damage...");
            health = health - damage;

            if (health > 0)
            {
                HealthBoost(healthboost);
            }
            else if (health <= 0)
            {
                health = 0;
            }
        }

        static void HealthCheck(int health)
        {            
            if (health > 75)
            {
                Console.WriteLine("Healthy");
            }
            else if (health > 49 && health < 75)
            {
                Console.WriteLine("Injured");
            }
            else if (health > 24 && health < 50)
            {
                Console.WriteLine("Badly Injured");
            }
            else if (health > 0 && health < 25)
            {
                Console.WriteLine("Death Imminent");
            }
        }

        static void ShowHud()
        {
            Console.WriteLine("Health: " + health);
            HealthCheck(health);
            WeaponCheck(weapon);            
            DeathCheck(health);
            
            Console.WriteLine();
        }

        static void DeathCheck(int health)
        {
            if (health <= 0)
            {
                Console.WriteLine();
                Console.WriteLine("You are deceased. Your loved ones, if any, will be notified.");
                loopend = true;
            }
        }

        static void WeaponCheck(int currentweapon)
        {
            if (currentweapon == 0)
            {
                Console.WriteLine("Currently Equipped Weapon: Fists");
                weapon++;
            }
            else if (currentweapon == 1)
            {
                Console.WriteLine("Currently Equipped Weapon: Brass Knuckles");
                weapon++;
            }
            else if (currentweapon == 2)
            {
                Console.WriteLine("Currently Equipped Weapon: Spiked Knuckles");
                weapon++;
            }
            else if (currentweapon == 3)
            {
                Console.WriteLine("Currently Equipped Weapon: Flaming Knuckles");
                weapon++;
            }
            else
            {
                Console.WriteLine("Currently Equipped Weapon: Infinite Knuckles");
                weapon = 0;
            }            
        }

        static void HealthBoost(int healthboost)
        {
            Console.WriteLine("Your regen will recover " + healthboost + " health.");
            health = health + healthboost;
        }
    }
}
