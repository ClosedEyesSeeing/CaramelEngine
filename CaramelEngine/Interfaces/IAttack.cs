using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IAttack<T>
    {
        // Note: Returns the Winner
        T Attack(T attack, T defend);
    }
}
