using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IDie : IRollable, IIdentifiable
    {
        int MinValue { get; set; }
        int MaxValue { get; set; }

        int SideCount { get; }

        IEnumerable<ISide> Sides { get; set; }
        
        /// <summary>
        /// The collection of dice this die is a part of, if any.
        /// </summary>
        IDice Collection { get; set; }
    }
}
