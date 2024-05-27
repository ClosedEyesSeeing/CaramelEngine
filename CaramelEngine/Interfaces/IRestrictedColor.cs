using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IRestrictedColor : IColor
    {
        int GreenMinValue { get; set; }
        int RedMinValue { get; set; }
        int BlueMinValue { get; set; }
        int BlackMinValue { get; set; }
        int WhiteMinValue { get; set; }
        int OtherMinValue { get; set; }
        int GreenMaxValue { get; set; }
        int RedMaxValue { get; set; }
        int BlueMaxValue { get; set; }
        int BlackMaxValue { get; set; }
        int WhiteMaxValue { get; set; }
        int OtherMaxValue { get; set; }

    }
}
