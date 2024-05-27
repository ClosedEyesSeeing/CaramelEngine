using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IBoard : ITargetable
    {
        Guid Id { get; set; }
        ActionStack Stack { get; set; }
    }

}
