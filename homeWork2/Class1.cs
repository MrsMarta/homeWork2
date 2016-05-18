using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWork2
{
    class Pirate
    {
        public string Name { get; set; }
        private List<string> nameList = new List<string> { "Blue Dog", "Steel Ass", "Infernal knight", "Dirty Marta", "Leonid bone king", "Hlado Mazer" };

        public int Height { get; set; }

        public int HitPoint { get; set; }

        public int AttackDamage { get; set; }

        public Pirate()
        {
            Random generator = new Random();
            Height = generator.Next(150, 221);
            int randomNameIndex = generator.Next(0, nameList.Count);
            HitPoint = Height + 50;
            AttackDamage = (Height + HitPoint) / 10;
            Name = randomNameIndex

        }
        
        
        

      
        
    }
}