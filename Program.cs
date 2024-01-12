using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Program
    {
        static void Main(string[] args) // <--- entry point to a program... doesn't matter what class it's in 
        {
            Console.WriteLine("This is a demo about classes in C#");
            Console.WriteLine();
            Console.WriteLine();

            int score; // declaration
            score = 0;
            Console.WriteLine("Score: " + score);

            // example array 
            int[] ammo; // declaration
            ammo = new int[5]; //instantiation
            ammo[0] = 5;

            // Player Instance
            Player player; // declaration
            player = new Player(); // instantiation

            player.x = 0;
            player.y = 0;
            player.health = 50;
            
            
            // Enemy Instances
            Enemy smallEnemy;
            smallEnemy = new Enemy();

            Enemy bossEnemy;
            bossEnemy = new Enemy();
            
            // Enemy array
            Enemy[] smallEnemies;
            smallEnemies = new Enemy[100];
            for (int i = 0; i < smallEnemies.Length; i++)
            {
                // ... 
            }
            
            smallEnemy.health = 25;
            smallEnemy.x = 10;
            smallEnemy.y = 10;


            bossEnemy.health = 200;

            Console.WriteLine("Player Health: " +  player.health);
            Console.WriteLine("Enemy Health: " +  smallEnemy.health);
            player.Heal();
            Console.WriteLine("Player Health: " +  player.health);
            Console.WriteLine();   
            Console.WriteLine("Boss Health: " +  bossEnemy.health);


            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
