using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface ISide : IIdentifiable
    {
        int Value { get; set; }

        IAbility Ability { get; set; }
    }
}
