using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelD.TemperatureSensor
{
    internal class Alarm
    {
        private byte AlarmValue { get; set; }

        public Alarm(byte alarmValueInti)
        {
            AlarmValue = alarmValueInti;
        }

        public void SetAlarmValue(byte newAlarm)
        {
            AlarmValue = newAlarm;
        }
        public void FireAlarm(object? obj, TempArgs args)
        {
            if (args.Temp > AlarmValue)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Take care, the temp value: {args.Temp}");
                Console.WriteLine($" is grater than {AlarmValue}");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}
