using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine
{
    // NOTE: This is pretty good for now, we'll probably need to expand upon it later.
    // TODO: I'd like to make it even more robust and create some more 'preset/base' useages for resources/points etc

    public interface IPoints
    {
        int VictoryPoints { get; set; }
        int CapturePoints { get; set; }
        int LifePoints { get; set; }
        int OtherPoints { get; set; }
    }
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
    public interface IReinforcement
    {
        int D4Reinforcements { get; set; }
        int D6Reinforcements { get; set; }
        int D8Reinforcements { get; set; }
        int D10Reinforcements { get; set; }
        int D12Reinforcements { get; set; }
        int D20Reinforcements { get; set; }
    }
    public class Reinforcement<P> : IReinforcement, IController<P>
    {
        #region IReinforcement Members

        public int D4Reinforcements
        {
            get;
            set;
        }

        public int D6Reinforcements
        {
            get;
            set;
        }

        public int D8Reinforcements
        {
            get;
            set;
        }

        public int D10Reinforcements
        {
            get;
            set;
        }

        public int D12Reinforcements
        {
            get;
            set;
        }

        public int D20Reinforcements
        {
            get;
            set;
        }

        #endregion

        #region IController<P> Members

        public P Owner
        {
            get;
            set;
        }

        public P Controller
        {
            get;
            set;
        }

        #endregion
    }
    public interface IResources : IColor, IPoints
    {
        Guid ID { get; set; }
    }
    public class Resources : IResources
    {
        #region IResources Members

        public Guid ID
        {
            get;
            set;
        }

        #endregion

        #region IColor Members

        public int Green
        {
            get;
            set;
        }

        public int Red
        {
            get;
            set;
        }

        public int Blue
        {
            get;
            set;
        }

        public int Black
        {
            get;
            set;
        }

        public int White
        {
            get;
            set;
        }

        public int Other
        {
            get;
            set;
        }

        public void ClearColors()
        {
            Green = 0;
            Blue = 0;
            Black = 0;
            Red = 0;
            White = 0;
            Other = 0;
        }

        public int CountColors()
        {
            return Green + Blue + Black + Red + White + Other;
        }

        #endregion

        #region IPoints Members

        public int VictoryPoints
        {
            get;
            set;
        }

        public int CapturePoints
        {
            get;
            set;
        }

        public int LifePoints
        {
            get;
            set;
        }

        public int OtherPoints
        {
            get;
            set;
        }

        #endregion
    }
    public class RestrictedResources : Resources, IRestrictedColor, IRestrictedPoints
    {
        private int _VictoryPoints { get; set; }        
        private int _CapturePoints { get; set; }        
        private int _LifePoints { get; set; }        
        private int _OtherPoints { get; set; }
        private int _Green { get; set; }
        private int _Red { get; set; }
        private int _Blue { get; set; }
        private int _Black { get; set; }
        private int _White { get; set; }
        private int _Other { get; set; }

        public int Green
        {
            get { return _Green; }
            set 
            {
                if (GreenMinValue == -1 && GreenMaxValue == -1)
                {
                    _Green = value;
                    return;
                }
                if (GreenMinValue == -1)
                    if (value <= GreenMaxValue)
                    {
                        _Green = value;
                        return;
                    }
                if (GreenMaxValue == -1)
                    if (value >= GreenMinValue)
                    {
                        _Green = value;
                        return;
                    }
                if (value >= GreenMinValue && value <= GreenMaxValue)
                {
                    _Green = value;
                    return;
                }
                throw new InvalidOperationException("Value is outside of member's range.");
            }
        }
        public int Blue
        {
            get { return _Blue; }
            set 
            {
                if (BlueMinValue == -1 && BlueMaxValue == -1)
                {
                    _Blue = value;
                    return;
                }
                if (BlueMinValue == -1)
                    if (value <= BlueMaxValue)
                    {
                        _Blue = value;
                        return;
                    }
                if (BlueMaxValue == -1)
                    if (value >= BlueMinValue)
                    {
                        _Blue = value;
                        return;
                    }
                if (value >= BlueMinValue && value <= BlueMaxValue)
                {
                    _Blue = value;
                    return;
                }
                throw new InvalidOperationException("Value is outside of member's range.");
            }
        }
        public int Black
        {
            get { return _Black; }
            set
            {
                if (BlackMinValue == -1 && BlackMaxValue == -1)
                {
                    _Black = value;
                    return;
                }
                if (BlackMinValue == -1)
                    if (value <= BlackMaxValue)
                    {
                        _Black = value;
                        return;
                    }
                if (BlackMaxValue == -1)
                    if (value >= BlackMinValue)
                    {
                        _Black = value;
                        return;
                    }
                if (value >= BlackMinValue && value <= BlackMaxValue)
                {
                    _Black = value;
                    return;
                }
                throw new InvalidOperationException("Value is outside of member's range.");
            }
        }
        public int Red
        {
            get { return _Red; }
            set
            {
                if (RedMinValue == -1 && RedMaxValue == -1)
                {
                    _Red = value;
                    return;
                }
                if (RedMinValue == -1)
                    if (value <= RedMaxValue)
                    {
                        _Red = value;
                        return;
                    }
                if (RedMaxValue == -1)
                    if (value >= RedMinValue)
                    {
                        _Red = value;
                        return;
                    }
                if (value >= RedMinValue && value <= RedMaxValue)
                {
                    _Red = value;
                    return;
                }
                throw new InvalidOperationException("Value is outside of member's range.");
            }
        }
        public int White
        {
            get { return _White; }
            set
            {
                if (WhiteMinValue == -1 && WhiteMaxValue == -1)
                {
                    _White = value;
                    return;
                }
                if (WhiteMinValue == -1)
                    if (value <= WhiteMaxValue)
                    {
                        _White = value;
                        return;
                    }
                if (WhiteMaxValue == -1)
                    if (value >= WhiteMinValue)
                    {
                        _White = value;
                        return;
                    }
                if (value >= WhiteMinValue && value <= WhiteMaxValue)
                {
                    _White = value;
                    return;
                }
                throw new InvalidOperationException("Value is outside of member's range.");
            }
        }
        public int Other
        {
            get { return _Other; }
            set
            {
                if (OtherMinValue == -1 && OtherMaxValue == -1)
                {
                    _Other = value;
                    return;
                }
                if (OtherMinValue == -1)
                    if (value <= OtherMaxValue)
                    {
                        _Other = value;
                        return;
                    }
                if (OtherMaxValue == -1)
                    if (value >= OtherMinValue)
                    {
                        _Other = value;
                        return;
                    }
                if (value >= OtherMinValue && value <= OtherMaxValue)
                {
                    _Other = value;
                    return;
                }
                throw new InvalidOperationException("Value is outside of member's range.");
            }
        }

        public RestrictedResources()
        {
        }

        //TODO: constructor with all values, to set rules up at once

        #region IRestrictedColor Members

        public int GreenMinValue
        {
            get;
            set;
        }

        public int RedMinValue
        {
            get;
            set;
        }

        public int BlueMinValue
        {
            get;
            set;
        }

        public int BlackMinValue
        {
            get;
            set;
        }

        public int WhiteMinValue
        {
            get;
            set;
        }

        public int OtherMinValue
        {
            get;
            set;
        }

        public int GreenMaxValue
        {
            get;
            set;
        }

        public int RedMaxValue
        {
            get;
            set;
        }

        public int BlueMaxValue
        {
            get;
            set;
        }

        public int BlackMaxValue
        {
            get;
            set;
        }

        public int WhiteMaxValue
        {
            get;
            set;
        }

        public int OtherMaxValue
        {
            get;
            set;
        }

        #endregion

        #region IRestrictedPoints Members

        public int VictoryPointsMinValue
        {
            get;
            set;
        }

        public int VictoryPointsMaxValue
        {
            get;
            set;
        }

        public int CapturePointsMinValue
        {
            get;
            set;
        }

        public int CapturePointsMaxValue
        {
            get;
            set;
        }

        public int LifePointsMinValue
        {
            get;
            set;
        }

        public int LifePointsMaxValue
        {
            get;
            set;
        }

        public int OtherPointsMinValue
        {
            get;
            set;
        }

        public int OtherPointsMaxValue
        {
            get;
            set;
        }

        #endregion
    }
}
