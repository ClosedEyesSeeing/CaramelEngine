using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface ICard
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Text { get; set; }
    }
}
