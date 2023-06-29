using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class ConsoleMon
    {
        public ConsoleMon() { }

        internal ConsoleMon(int health, int energy, string name, Element weakness) {
            this.name = name;
            this.health = health;
            this.energy = energy;
            this.weakness = weakness;
        }

        public int health { get; set; }
        public int energy { get; set; }
        public string name { get; set; }
        public Element weakness { get; set; }
        public List<Skill> skills { get; set; }
        public Element element { get; set; }


        internal void TakeDamage(int damage)
        {
            health -= damage;
        }

        internal void DepleteEnergy(int energy)
        {
            this.energy -= energy;
        }
    }
}
    