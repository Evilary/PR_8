using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PR_8.Chernyshkov.Classes
{
    public class LiteVoin : Voin
    {
        public LiteVoin(string name, int maxHealth) : base(name, maxHealth) { }

        public override void TakeDamage(int damage)
        {
            
            int actualDamage = (int)(damage * 0.7);
            Health -= actualDamage;
            if (Health < 0) Health = 0;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Воин в легких доспехах: {Name}");
            Console.WriteLine($"Здоровье: {Health}/{MaxHealth}");
            Console.WriteLine($"Защита: 30%");
        }

    }
}
