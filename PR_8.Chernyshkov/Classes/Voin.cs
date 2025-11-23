using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_8.Chernyshkov.Classes
{
    public class Voin
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public Voin(string name, int maxHealth) 
        {
        
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
        
        
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0) Health = 0;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Воин: {Name}");
            Console.WriteLine($"Здоровье: {Health}/{MaxHealth}");
        }

    }
}
