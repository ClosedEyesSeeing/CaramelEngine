using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IRollable
    {
        int Roll();
        
    }
    public interface IMultipleRollable : IRollable
    {
        Stack<int> Roll(int numberOfRolls);
    }
    public interface ISideRollable : IRollable
    {
        ISide SideRoll();
        Stack<ISide> SideRoll(int numberOfRolls);
    }
}
