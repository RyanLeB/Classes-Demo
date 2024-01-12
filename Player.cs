using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Player
    {
        // defaults to private
        
        // members - fields (variables)
        public int health;
        public int shield;
        public int score;
        public int x; // position
        public int y; // position
        
        // members - methods

        // constructor
        public Player()
        {
            Console.WriteLine("Player constructed...");
        
            
            // you can initialize in here as well
            // health = 100;
            // shield = 0;
            // score = 0;
            // x = 0;
            // y = 0;


        }
        
        
        public void Heal()
        {
            health = 100;
        }

    }
}
