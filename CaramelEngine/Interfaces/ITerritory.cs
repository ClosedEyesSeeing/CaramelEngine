using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface ITerritory : ITargetable
    {
        Guid Id { get; set; }
        string Name { get; set; }
        //List<ITerritory> ConnectedTerritories { get; set; }       
    }
}
