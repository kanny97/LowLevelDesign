using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    public class EnemyPrototypeRegistry
    {
        private readonly Dictionary<string, Enemy> prototypes = new();
        public void RegisterPrototype(string key, Enemy prototype)
        {
            if (prototypes.ContainsKey(key))
            {
                throw new ArgumentException($"Prototype with key '{key}' already exists.");
            }
            prototypes[key] = prototype;
        }
        public Enemy GetPrototype(string key)
        {
            if (!prototypes.TryGetValue(key, out var prototype))
            {
                throw new KeyNotFoundException($"No prototype found for key '{key}'.");
            }
            return prototype.Clone();
        }
    }
}
