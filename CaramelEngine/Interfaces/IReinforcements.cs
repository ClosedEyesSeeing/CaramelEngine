using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{

    public interface IReinforcement
    {
        int D4Reinforcements { get; set; }
        int D6Reinforcements { get; set; }
        int D8Reinforcements { get; set; }
        int D10Reinforcements { get; set; }
        int D12Reinforcements { get; set; }
        int D20Reinforcements { get; set; }
    }
}
