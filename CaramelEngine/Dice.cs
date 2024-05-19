using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CaramelEngine
{
    // Note: Dice are pretty much done, not much to them.
    // TODO: I'd like to make each dice trackable by controller (player, board, territory)
    // TODO: I'd also like to make each dice targetable - but that may be overkill for them


    public interface IDice
    {
        int diceCount { get; }
        int d4Count { get; set; }
        int d6Count { get; set; }
        int d8Count { get; set; }
        int d10Count { get; set; }
        int d12Count { get; set; }
        int d20Count { get; set; }
    }

    public class RestrictedDice : IDice
    {
        private int d4;
        private int d6;
        private int d8;
        private int d10;
        private int d12;
        private int d20;

        public int MinD4 { get; set; }
        public int MinD6 { get; set; }
        public int MinD8 { get; set; }
        public int MinD10 { get; set; }
        public int MinD12 { get; set; }
        public int MinD20 { get; set; }

        public int MaxD4 { get; set; }
        public int MaxD6 { get; set; }
        public int MaxD8 { get; set; }
        public int MaxD10 { get; set; }
        public int MaxD12 { get; set; }
        public int MaxD20 { get; set; }

        public RestrictedDice()
        {
            d4 = 0;
            d6 = 0;
            d8 = 0;
            d12 = 0;
            d20 = 0;
            MinD4 = 0;
            MinD6 = 0;
            MinD8 = 0;
            MinD10 = 0;
            MinD12 = 0;
            MinD20 = 0;
            MaxD4 = -1;
            MaxD6 = -1;
            MaxD8 = -1;
            MaxD10 = -1;
            MaxD12 = -1;
            MaxD20 = -1;

        }
        public RestrictedDice(int _mind4, int _mind6, int _mind8, int _mind10, int _mind12, int _mind20, int _maxd4, int _maxd6, int _maxd8, int _maxd10, int _maxd12, int _maxd20)
        {
            d4 = 0;
            d6 = 0;
            d8 = 0;
            d12 = 0;
            d20 = 0;
            MinD4 = _mind4;
            MinD6 = _mind6;
            MinD8 = _mind8;
            MinD10 = _mind10;
            MinD12 = _mind12;
            MinD20 = _mind20;
            MaxD4 = _maxd4;
            MaxD6 = _maxd6;
            MaxD8 = -_maxd8;
            MaxD10 = _maxd10;
            MaxD12 = _maxd12;
            MaxD20 = _maxd20;
        }


        #region IDice Members

        public int diceCount
        {
            get { return (d4Count + d6Count + d8Count + d10Count + d12Count + d20Count); }            
        }

        public int d4Count
        {
            get { return d4; }
            set
            {
                if (MaxD4 != -1)
                    if (value <= MaxD4 && value >= MinD4)
                        d4 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD4 + " - " + MaxD4);
                else
                    if (value >= MinD4)
                        d4 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD4 + " - " + MaxD4);
            }
        }

        public int d6Count
        {
            get { return d6; }
            set
            {
                if (MaxD6 != -1)
                    if (value <= MaxD6 && value >= MinD6)
                        d6 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD6 + " - " + MaxD6);
                else
                    if (value >= MinD6)
                        d6 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD6 + " - " + MaxD6);
            }
        }

        public int d8Count
        {
            get { return d8; }
            set
            {
                if (MaxD8 != -1)
                    if (value <= MaxD8 && value >= MinD8)
                        d8 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD8 + " - " + MaxD8);
                else
                    if (value >= MinD8)
                        d8 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD8 + " - " + MaxD8);
            }
        }

        public int d10Count
        {
            get { return d10; }
            set
            {
                if (MaxD10 != -1)
                    if (value <= MaxD10 && value >= MinD10)
                        d10 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD10 + " - " + MaxD10);
                else
                    if (value >= MinD10)
                        d10 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD10 + " - " + MaxD10);
            }
        }

        public int d12Count
        {
            get { return d12; }
            set
            {
                if (MaxD12 != -1)
                    if (value <= MaxD12 && value >= MinD12)
                        d12 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD12 + " - " + MaxD12);
                else
                    if (value >= MinD12)
                        d12 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD12 + " - " + MaxD12);
            }
        }

        public int d20Count
        {
            get { return d20; }
            set
            {
                if (MaxD20 != -1)
                    if (value <= MaxD20 && value >= MinD20)
                        d20 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD20 + " - " + MaxD20);
                else
                    if (value >= MinD20)
                        d20 = value;
                    else
                        throw new InvalidOperationException("The value is restricted to " + MinD20 + " - " + MaxD20);
            }
        }

        #endregion
    }

    public class Dice : IGenericTarget
    {
        public const string D4Type = "D4";
        public const string D6Type = "D6";
        public const string D8Type = "D8";
        public const string D10Type = "D10";
        public const string D12Type = "D12";
        public const string D20Type = "D20";

        public int MinRollValue { get; set; }
        public int MaxRollIncrease { get; set; }

        public Dice()
        {
            MinRollValue = 1;
            MaxRollIncrease = 0;
        }

        private static Random dice = new Random();
        public int RollD4()
        {
            lock (dice)
                return dice.Next(MinRollValue, 4 + MaxRollIncrease);
        }
        public int[] RollD4(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(RollD4());
                diceCount--;
            }
            return diceList.ToArray();
        }

        public int RollD6()
        {
            lock (dice)
                return dice.Next(MinRollValue, 6 + MaxRollIncrease);
        }
        public int[] RollD6(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(RollD6());
                diceCount--;
            }
            return diceList.ToArray();
        }

        public int RollD8()
        {
            lock (dice)
                return dice.Next(MinRollValue, 8 + MaxRollIncrease);
        }
        public int[] RollD8(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(RollD8());
                diceCount--;
            }
            return diceList.ToArray();
        }

        public int RollD10()
        {
            lock (dice)
                return dice.Next(MinRollValue, 10 + MaxRollIncrease);
        }
        public int[] RollD10(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(RollD10());
                diceCount--;
            }
            return diceList.ToArray();
        }

        public int RollD12()
        {
            lock (dice)
                return dice.Next(MinRollValue, 12 + MaxRollIncrease);
        }
        public int[] RollD12(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(RollD12());
                diceCount--;
            }
            return diceList.ToArray();
        }

        public int RollD20()
        {
            lock (dice)
                return dice.Next(MinRollValue, 20 + MaxRollIncrease);
        }
        public int[] RollD20(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(RollD20());
                diceCount--;
            }
            return diceList.ToArray();
        }

        
    }

    #region Perhaps move this to Game, vs Engine

    public interface IRollDice
    {
        int Roll();
        List<int> Roll(int diceCount);
    }

    public class ControlledDice<T> : Dice, IController<T> where T : IGenericTarget
    {
        #region IController<T> Members

        public T Owner
        {
            get;
            set;
        }

        public T Controller
        {
            get;
            set;
        }

        #endregion
    }


    public class ControlledD4Dice : ControlledDice<IGenericTarget>, IRollDice
    {
        private static Random dice = new Random();

        #region IRollDice Members

        public int Roll()
        {
            int MaxRollValue = 4 + MaxRollIncrease;
            int tempInt = MinRollValue;
            if (MinRollValue > (MaxRollValue / 2))
                MinRollValue = (MaxRollValue / 2);
            lock (dice)
            {
                int rollInt = dice.Next(MinRollValue, MaxRollValue);
                MinRollValue = tempInt;
                return rollInt;
            }
        }

        public List<int> Roll(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(Roll());
                diceCount--;
            }
            return diceList;
        }

        #endregion
    }

    public class ControlledD6Dice : ControlledDice<IGenericTarget>, IRollDice
    {
        private static Random dice = new Random();

        #region IRollDice Members

        public int Roll()
        {
            int MaxRollValue = 6 + MaxRollIncrease;
            int tempInt = MinRollValue;
            if (MinRollValue > (MaxRollValue / 2))
                MinRollValue = (MaxRollValue / 2);
            lock (dice)
            {
                int rollInt = dice.Next(MinRollValue, MaxRollValue);
                MinRollValue = tempInt;
                return rollInt;
            }
        }

        public List<int> Roll(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(Roll());
                diceCount--;
            }
            return diceList;
        }

        #endregion
    }

    public class ControlledD8Dice : ControlledDice<IGenericTarget>, IRollDice
    {
        private static Random dice = new Random();

        #region IRollDice Members

        public int Roll()
        {
            int MaxRollValue = 8 + MaxRollIncrease;
            int tempInt = MinRollValue;
            if (MinRollValue > (MaxRollValue / 2))
                MinRollValue = (MaxRollValue / 2);
            lock (dice)
            {
                int rollInt = dice.Next(MinRollValue, MaxRollValue);
                MinRollValue = tempInt;
                return rollInt;
            }
        }

        public List<int> Roll(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(Roll());
                diceCount--;
            }
            return diceList;
        }

        #endregion
    }

    public class ControlledD10Dice : ControlledDice<IGenericTarget>, IRollDice
    {
        private static Random dice = new Random();

        #region IRollDice Members

        public int Roll()
        {
            int MaxRollValue = 10 + MaxRollIncrease;
            int tempInt = MinRollValue;
            if (MinRollValue > (MaxRollValue / 2))
                MinRollValue = (MaxRollValue / 2);
            lock (dice)
            {
                int rollInt = dice.Next(MinRollValue, MaxRollValue);
                MinRollValue = tempInt;
                return rollInt;
            }
        }

        public List<int> Roll(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(Roll());
                diceCount--;
            }
            return diceList;
        }

        #endregion
    }

    public class ControlledD12Dice : ControlledDice<IGenericTarget>, IRollDice
    {
        private static Random dice = new Random();

        #region IRollDice Members

        public int Roll()
        {
            int MaxRollValue = 12 + MaxRollIncrease;
            int tempInt = MinRollValue;
            if (MinRollValue > (MaxRollValue / 2))
                MinRollValue = (MaxRollValue / 2);
            lock (dice)
            {
                int rollInt = dice.Next(MinRollValue, MaxRollValue);
                MinRollValue = tempInt;
                return rollInt;
            }
        }

        public List<int> Roll(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(Roll());
                diceCount--;
            }
            return diceList;
        }

        #endregion
    }

    public class ControlledD20Dice : ControlledDice<IGenericTarget>, IRollDice
    {
        private static Random dice = new Random();

        #region IRollDice Members

        public int Roll()
        {
            int MaxRollValue = 20 + MaxRollIncrease;
            int tempInt = MinRollValue;
            if (MinRollValue > (MaxRollValue / 2))
                MinRollValue = (MaxRollValue / 2);
            lock (dice)
            {
                int rollInt = dice.Next(MinRollValue, MaxRollValue);
                MinRollValue = tempInt;
                return rollInt;
            }
        }

        public List<int> Roll(int diceCount)
        {
            List<int> diceList = new List<int>();
            while (diceCount > 0)
            {
                diceList.Add(Roll());
                diceCount--;
            }
            return diceList;
        }

        #endregion
    } 

    

    #endregion
}
