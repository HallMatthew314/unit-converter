using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public enum EWeights
    {
        Grams,
        Pounds,
        Stone
    }

    public class WeightMode : Mode
    {
        public WeightMode(Form1 _host) : base(_host)
        {
            conversions = new Dictionary<int, Dictionary<int, Func<double, double>>>()
            {
                // base unit grams
                {
                    (int)EWeights.Grams, new Dictionary<int, Func<double, double>>()
                    {
                        { (int)EWeights.Grams, (x) => x },
                        { (int)EWeights.Pounds, (x) => ConversionMethods.gTolb(x) },
                        { (int)EWeights.Stone, (x) => ConversionMethods.gToStone(x) }
                    }
                },
                // base unit pounds
                {
                    (int)EWeights.Pounds, new Dictionary<int, Func<double, double>>()
                    {
                        { (int)EWeights.Grams, (x) => ConversionMethods.lbTog(x) },
                        { (int)EWeights.Pounds, (x) => x },
                        { (int)EWeights.Stone, (x) => ConversionMethods.lbToStone(x) }
                    }
                },
                // base unit stone
                {
                    (int)EWeights.Stone, new Dictionary<int, Func<double, double>>()
                    {
                        { (int)EWeights.Grams, (x) => ConversionMethods.stoneTog(x) },
                        { (int)EWeights.Pounds, (x) => ConversionMethods.stoneTolb(x) },
                        { (int)EWeights.Stone, (x) => x }
                    }
                }
            };
        }

        public override Array UnitValues
        {
            get => Enum.GetValues(typeof(EWeights));
        }

        public override string ToString()
        {
            return "Weight Mode";
        }
    }
}
