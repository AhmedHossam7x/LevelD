using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LevelD.TemperatureSensor
{
    internal class Sensor
    {
        public event EventHandler<TempArgs>? TempHandler;
        private byte CurrentTemp { get; set; }
        public void ChangeTemp(byte newTemp)
        {
            CurrentTemp = newTemp;
            TempHandler?.Invoke(this, new TempArgs(newTemp));
        }

    }
}
