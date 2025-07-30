using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class PrototypeDemo
    {
        public static void Main(string[] args)
        {
            EnemyPrototypeRegistry registry = new EnemyPrototypeRegistry();
            registry.RegisterPrototype("flying", new Enemy("FlyingEnemy", 100, 12.0, false, "Laser"));
            registry.RegisterPrototype("armored", new Enemy("ArmoredEnemy", 300, 6.0, true, "Cannon"));

            Enemy flyingEnemy = registry.GetPrototype("flying");
            Enemy armoredEnemy = registry.GetPrototype("armored");
            flyingEnemy.PrintStats();
            armoredEnemy.PrintStats();

            Enemy clonedFlyingEnemy = flyingEnemy.Clone();
            clonedFlyingEnemy.PrintStats();
        }
    }
}
