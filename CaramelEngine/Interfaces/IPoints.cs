using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IPoints
    {
        int VictoryPoints { get; set; }
        int CapturePoints { get; set; }
        int LifePoints { get; set; }
        int OtherPoints { get; set; }
    }
}
