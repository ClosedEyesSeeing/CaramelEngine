using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IAbility
    {
        string Name { get; set; }
        string Text { get; set; }
        IAction Action { get; set; }
    }
}
