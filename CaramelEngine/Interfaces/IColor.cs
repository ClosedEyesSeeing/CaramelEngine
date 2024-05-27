using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IColor
    {
        int Green { get; set; }
        int Red { get; set; }
        int Blue { get; set; }
        int Black { get; set; }
        int White { get; set; }
        int Other { get; set; }

        void ClearColors();

        int CountColors();
    }
}
