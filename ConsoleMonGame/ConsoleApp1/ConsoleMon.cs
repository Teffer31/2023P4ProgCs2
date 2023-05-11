using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    private const string V = "name";

    internal class ConsoleMon
    {
        int health;
        int energy;
        string name V;
    }

    internal void TakeDamage(int damage)
    {
        health-= damage;
    }

    internal void DepleteEnergy(int energy)
    {
        this.energy-= energy;
    }
}