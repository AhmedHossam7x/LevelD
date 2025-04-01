using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelD.TemperatureSensor
{
    internal class TempArgs : EventArgs
    {
        public byte Temp { get; set; }

        public TempArgs(byte temp)
        {
            Temp = temp;
        }
    }
}
