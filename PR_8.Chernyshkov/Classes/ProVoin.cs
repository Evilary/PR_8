using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PR_8.Chernyshkov.Classes
{
    internal class ProVoin : Voin
    {

        public ProVoin(string name, int maxHealth) : base(name, maxHealth) { }

        public override void TakeDamage(int damage)
        {
            
            int actualDamage = (int)(damage * 0.5);
            Health -= actualDamage;
            if (Health < 0) Health = 0;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Воин в тяжелых доспехах: {Name}");
            Console.WriteLine($"Здоровье: {Health}/{MaxHealth}");
            Console.WriteLine($"Защита: 50%");
        }
    }
}
