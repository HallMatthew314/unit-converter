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
        public WeightMode(Form1 _host) : base(_host){}

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
