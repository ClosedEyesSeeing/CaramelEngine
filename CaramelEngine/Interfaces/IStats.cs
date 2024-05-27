using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IStats
    {
        int HealthPoints { get; set; }
        int ManaPoints { get; set; }
        int Currencey { get; set; }
        int ArmorPoints { get; set; }
        int Strength { get; set; }
        int Stamina { get; set; }
        int Intellect { get; set; }
        int Agility { get; set; }
        int ActionPoints { get; set; }
    }
}
