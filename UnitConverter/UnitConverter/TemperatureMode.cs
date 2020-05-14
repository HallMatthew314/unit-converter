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
        public TemperatureMode(Form1 _host) : base(_host)
        {
            conversions = new Dictionary<int, Dictionary<int, Func<double, double>>>()
            {
                // base unit celsius
                {
                    (int)ETemperatures.Celsius, new Dictionary<int, Func<double, double>>()
                    {
                        { (int)ETemperatures.Celsius, (x) => x },
                        { (int)ETemperatures.Fahrenheit, (x) => ConversionMethods.cToF(x) },
                        { (int)ETemperatures.Kelvin, (x) => ConversionMethods.cToK(x) }
                    }
                },
                // base unit fahrenheit
                {
                    (int)ETemperatures.Fahrenheit, new Dictionary<int, Func<double, double>>()
                    {
                        { (int)ETemperatures.Celsius, (x) => ConversionMethods.fToC(x) },
                        { (int)ETemperatures.Fahrenheit, (x) => x },
                        { (int)ETemperatures.Kelvin, (x) => ConversionMethods.fToK(x) }
                    }
                },
                // base unit kelvin
                {
                    (int)ETemperatures.Kelvin, new Dictionary<int, Func<double, double>>()
                    {
                        { (int)ETemperatures.Celsius, (x) => ConversionMethods.kToC(x) },
                        { (int)ETemperatures.Fahrenheit, (x) => ConversionMethods.kToF(x) },
                        { (int)ETemperatures.Kelvin, (x) => x }
                    }
                }
            };
        }

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
