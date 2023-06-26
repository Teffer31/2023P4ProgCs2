
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Skill
    {
        internal int damage;
        internal int energyCost;
        internal string name = "name";
        internal Element element;

        internal void UseOn(ConsoleMon target, ConsoleMon Caster)
        {
            Caster.DepleteEnergy(energyCost);
            target.TakeDamage(damage);
        }
    }
}
