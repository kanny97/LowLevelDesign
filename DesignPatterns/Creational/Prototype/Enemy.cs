using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Creational.Prototype
{
    public class Enemy : IEnemyPrototype
    {
        private string type;
        private int health;
        private double speed;
        private bool armored;
        private string weapon;
        public Enemy(string type, int health, double speed, bool armored, string weapon)
        {
            this.type = type;
            this.health = health;
            this.speed = speed;
            this.armored = armored;
            this.weapon = weapon;
        }
        public Enemy Clone()
        {
            return new Enemy(type, health, speed, armored, weapon);  
        }
        public void PrintStats()
        {
            Console.WriteLine(type + " [Health: " + health +
                               ", Speed: " + speed +
                               ", Armored: " + armored +
                               ", Weapon: " + weapon + "]");
        }
    }
}
