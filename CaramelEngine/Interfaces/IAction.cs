using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IAction<T> : IAction where T : ITargetable
    {
        T Target { get; set; }
    }

    public interface IAction : IIdentifiable
    {

    }
}
