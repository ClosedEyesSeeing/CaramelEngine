using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IDice
    {
        int MinimumAmount { get; set; }
        int MaximumAmount { get; set; }
        IEnumerable<IDie> DiceCollection { get; }
    }
}
