using System;

namespace Szkielet.Clocks
{
    public class Watch : Clock
    {
        public readonly ConsoleColor Color;
        protected override string Sound { get; } = "Tick Tock";
        
        public Watch(int hour, int minute, int second, ConsoleColor color) : base(hour, minute, second)
        {
            Color = color;
        }
        public Watch(string name, string util, ConsoleColor color) : base(name, Utils.AlarmClock, color)
        {
            
        }

        
    }
}