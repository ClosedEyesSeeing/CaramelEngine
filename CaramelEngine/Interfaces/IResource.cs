using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IResource : IIdentifiable //: IColor, IPoints
    {
        string Name { get; set; }
    }
}
