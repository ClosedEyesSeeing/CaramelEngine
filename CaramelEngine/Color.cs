using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CaramelEngine
{

    // NOTE: Colors are colors, not much to implement.
    // TODO: I'd like to make it a little more extensible. 
    
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
    public static class Color
    {
        public const string Green = "Green";
        public const string Blue = "Blue";
        public const string Black = "Black";
        public const string Red = "Red";
        public const string White = "White";
        public const string Purple = "Purple";
        public const string Pink = "Pink";
        public const string Yellow = "Yellow";
        public const string Clear = "Clear";
        public const string Brown = "Brown";
        public const string Other = "Other";
    }
}
