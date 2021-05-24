using System;
using System.Collections.Generic;
using Szkielet.Clocks;
using static System.Console;

namespace Szkielet
{
    public static  class Utils


    {
        public static readonly Random Random = new();
        public static string AlarmClock = @"    
                                          
  ((  (__I__)  ))
    .'_....._'.
   / / .12 . \ \
  | | '  |  ' | |
  | | 9  /  3 | |
   \ \ '.6.' / /
    '.`-...-'.'
jgs  /'-- --'\ )";

        public static string Watch = @"

              _..._
      |_____|
      |_____|
      |_____|
      |_____|
      |_____|
     / _____ \
     ||  '  ||
     ||  |  ||
     ||- | -||)
     ||   \ ||
     ||__.__||
jgs  \_______/
      |_____|
      |_____|
      |_____|
      |_____|
      |_   _|";

        public static string WallClock =@"

 _
        ,/_\,
      ,/_/ \_\,
     /_/ ___ \_\
    /_/ |(V)| \_\
      |  .-.  |
      | / / \ |
      | \ \ / |
      |  '-'  |
      '--,-,--'
  jgs    | |
         | |
         | |
         /\|
         \/|
          /\
          \/";
        
        public static string BigBen =@"

/_________/`-_
 _-'          `-_ /|
{                } |
|  ____________  | |
| |    \/||    | | |
| |    /\||    | | |
| |            | | |
| ||\/      |||| | |
| ||/\ ,*.  |||| | |
| |  ,'   `.   | | |
| |    \ /| `. | | |
| |_____V_|____| | |
| |    : /     | | |
| |    :/:     | | |
| |    / :     | | |
| |   /: @     | | |  _|_ .    |   _|_ .    |
| |  / :       | | |   |  | /` |/   |  | /` |/
| |( ) :       | | |   |  | \, |\   |  | \, |\
| |    :       | | |
| |    :       | | |
| |    :       | | |
| |    :       | | |
| |    :       | | |
| |    @       | | |
| |____________| | |  
|______ejm_______|/

  ";

        public static List<Clock> _clocks1;


        public static List<Clock> Intro()
        
        {
            var alarmClock = new AlarmClock("Alarm Clock", Utils.AlarmClock, ConsoleColor.DarkRed);

            var bigBen = new BigBen("BigBen", Utils.BigBen, ConsoleColor.DarkBlue);
            var wallClock = new WallClock("Wall Clock", Utils.BigBen, ConsoleColor.Yellow);
            var watch = new Watch("Watch", Utils.Watch, ConsoleColor.Cyan);
            _clocks1 = new List<Clock>() {alarmClock, bigBen, wallClock, watch};
            foreach (var clock in _clocks1)
            {
                clock.DisplayClock();
            }

            
            return _clocks1;
        }
        

        public static void Outro()
        {
            WriteLine("I hope you like my Shop");
            WriteLine("I hope I pass ;)");
        }

        public static void WaitForKey()
        {
            WriteLine("Press any key to continue");
            ReadKey(true);
        }

        public static void Exit()
        {
            WriteLine("Press any key to exit...");
            ReadKey(true);
        }
        
        public static void Welcome()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
 ▄█     █▄     ▄████████  ▄█        ▄████████  ▄██████▄    ▄▄▄▄███▄▄▄▄      ▄████████          ███      ▄██████▄          ▄███████▄    ▄████████ 
███     ███   ███    ███ ███       ███    ███ ███    ███ ▄██▀▀▀███▀▀▀██▄   ███    ███      ▀█████████▄ ███    ███        ███    ███   ███    ███ 
███     ███   ███    █▀  ███       ███    █▀  ███    ███ ███   ███   ███   ███    █▀          ▀███▀▀██ ███    ███        ███    ███   ███    ███ 
███     ███  ▄███▄▄▄     ███       ███        ███    ███ ███   ███   ███  ▄███▄▄▄              ███   ▀ ███    ███        ███    ███   ███    ███ 
███     ███ ▀▀███▀▀▀     ███       ███        ███    ███ ███   ███   ███ ▀▀███▀▀▀              ███     ███    ███      ▀█████████▀  ▀███████████ 
███     ███   ███    █▄  ███       ███    █▄  ███    ███ ███   ███   ███   ███    █▄           ███     ███    ███        ███          ███    ███ 
███ ▄█▄ ███   ███    ███ ███▌    ▄ ███    ███ ███    ███ ███   ███   ███   ███    ███          ███     ███    ███        ███          ███    ███ 
 ▀███▀███▀    ██████████ █████▄▄██ ████████▀   ▀██████▀   ▀█   ███   █▀    ██████████         ▄████▀    ▀██████▀        ▄████▀        ███    █▀  "); 
            ResetColor();
            WaitForKey();
        }
      
        
        
    }
}