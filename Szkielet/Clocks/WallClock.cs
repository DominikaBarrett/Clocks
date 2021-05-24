using System;

namespace Szkielet.Clocks
{
    public class WallClock :Clock
    {
        
        protected override string Sound { get; } = "Cuckoo";
        
        public WallClock(int hour, int minute, int second) : base(hour, minute, second)
        {
        }
        public WallClock(string name, string util, ConsoleColor color) : base(name, Utils.WallClock, color)
        {
        }
    }
}