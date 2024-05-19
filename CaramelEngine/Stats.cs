using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine
{
    // NOTE: This will be where all point related things would go.
    // perhaps we could make some 'preset/base' stat configurations
    // ie. RPG, TableTop, Card
    // TODO: I'd like to make this more extensible.

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
    public class Stats : IStats
    {
        #region IStats Members

        public int HealthPoints
        {
            get;
            set;
        }

        public int ManaPoints
        {
            get;
            set;
        }

        public int Currencey
        {
            get;
            set;
        }

        public int ArmorPoints
        {
            get;
            set;
        }

        public int Strength
        {
            get;
            set;
        }

        public int Stamina
        {
            get;
            set;
        }

        public int Intellect
        {
            get;
            set;
        }

        public int Agility
        {
            get;
            set;
        }

        public int ActionPoints
        {
            get;
            set;
        }

        #endregion
    }
}
