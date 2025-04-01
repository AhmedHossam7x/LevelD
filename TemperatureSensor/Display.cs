using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelD.TemperatureSensor
{
    internal class Display
    {
        public void ShowTemp(object obj, TempArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"The temp is {args.Temp}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
