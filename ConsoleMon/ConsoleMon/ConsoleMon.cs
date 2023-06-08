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
        internal int health;
        internal int energy;
        internal string name;
        private List<Skill> skills;
        internal Element element;


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
    