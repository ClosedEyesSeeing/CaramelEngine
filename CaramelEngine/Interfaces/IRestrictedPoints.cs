using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine.Interfaces
{
    public interface IRestrictedPoints : IPoints
    {
        int VictoryPointsMinValue { get; set; }
        int VictoryPointsMaxValue { get; set; }
        int CapturePointsMinValue { get; set; }
        int CapturePointsMaxValue { get; set; }
        int LifePointsMinValue { get; set; }
        int LifePointsMaxValue { get; set; }
        int OtherPointsMinValue { get; set; }
        int OtherPointsMaxValue { get; set; }
    }
}
