using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public enum EMode
    {
        DISTANCE,
        WEIGHT,
        TEMPERATURE
    }

    abstract class Mode
    {
        public Mode Update(EMode _mode)
        {
            Mode m = null;

            switch (_mode)
            {
                case EMode.DISTANCE:
                    m = new DistanceMode();
                    break;

                case EMode.WEIGHT:
                    m = new WeightMode();
                    break;

                case EMode.TEMPERATURE:
                    m = new TemperatureMode();
                    break;

                default:
                    throw new ArgumentOutOfRangeException("Bad value for _mode");
            }

            return m;
        }

        public double ConvertUnit()
        {
            throw new NotImplementedException();
        }

        public abstract override string ToString();
    }
}
