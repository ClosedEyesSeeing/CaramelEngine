using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IIdentifiable
    {
        Guid Id { get; set; }
    }
}
