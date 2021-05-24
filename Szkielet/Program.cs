using System;
using System.Runtime.ConstrainedExecution;
using System.Security.Policy;

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Szkielet.Clocks;

namespace Szkielet
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Shop shop = new Shop();
            var clocks = shop.GenerateClocks(15);
            Utils.Welcome();
            Utils.Intro();
            
           
            

            int i = 1;
           
            while (true)
            {
                Console.Clear();
                int randClock = Utils.Random.Next(1, clocks.Count);
                int randHour = Utils.Random.Next(0, 23);
                string alarmInfo = null;
                string setInfo = null;

                foreach ( var clock in clocks.Values)
                {
                    if (i == randClock)
                    {
                        if (clock is not AlarmClock)
                        {
                            clock.SetTime(randHour, 59, 55);
                            setInfo = $"{clock.GetType().Name} (No {i}) has been set to {randHour}:59:55.";
                        }

                        if (clock is AlarmClock alarmClock)
                        {
                            if (alarmClock.Alarm == null)
                            {
                                var currentClockTime =
                                    new TimeSpan(alarmClock.Hour, alarmClock.Minute, alarmClock.Second);
                                var alarm = currentClockTime.Add(new TimeSpan(0, 1, 0));

                                alarmClock.SetAlarm(alarm.Hours, alarm.Minutes, alarm.Seconds);
                                alarmInfo =
                                    $"AlarmClock (No {i}) has been set to {alarm.Hours}:{alarm.Minutes}:{alarm.Seconds}.";
                            }
                        }
                    }

                    clock.ReadTime(i);
                    i++;
                }

                if (!string.IsNullOrEmpty(setInfo))
                {
                    Console.WriteLine(setInfo);
                }
                
                if (!string.IsNullOrEmpty(alarmInfo))
                {
                    Console.WriteLine(alarmInfo);
                }

                Thread.Sleep(1000);

                i = 1;
            }
        }
    }

    
}