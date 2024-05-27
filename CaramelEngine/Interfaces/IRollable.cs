using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IRollable
    {
        int Roll(int sides);
        Stack<int> Roll(int sides, int amountOfDice);

        //IAbility Roll(int sides);
        //Stack<IAbility> Roll(int sides, int amountOfDice); 
    }
}
