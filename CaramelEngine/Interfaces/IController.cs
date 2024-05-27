using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IController<T>
    {
        T Owner { get; set; }
        T Controller { get; set; }
    }
}
