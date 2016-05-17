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
        Random Generator = new Random();

        int Height1 = Generator.Next(150, 221);
        private static object Generator;

        public Pirate(int Height)
        {
            this.Height1 = Height;
        }
        
        public int HitPoint { get; set; }
        private int GetHitpointsByHeight(int height);

        HitPoints = GetHitPointsByHeight(height)
        public int AttackDamage { get; set; }

      
        }
    }
}