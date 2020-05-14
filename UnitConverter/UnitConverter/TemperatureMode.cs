using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public enum ETemperatures
    {
        Celsius,
        Fahrenheit,
        Kelvin
    }

    public class TemperatureMode : Mode
    {
        public TemperatureMode(Form1 _host) : base(_host){}

        public override Array UnitValues
        {
            get => Enum.GetValues(typeof(ETemperatures));
        }

        public override string ToString()
        {
            return "Temperature Mode";
        }
    }
}
