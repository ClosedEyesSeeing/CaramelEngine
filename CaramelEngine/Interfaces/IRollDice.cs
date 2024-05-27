using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IRollDice
    {
        int Roll();
        List<int> Roll(int diceCount);
    }
}
