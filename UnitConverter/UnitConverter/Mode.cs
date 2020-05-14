﻿using System;
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

    public abstract class Mode
    {
        protected Form1 host;

        public Mode(Form1 _host)
        {
            host = _host;
        }

        public void Update(EMode _mode)
        {
            switch (_mode)
            {
                case EMode.DISTANCE:
                    host.CurrentMode = new DistanceMode(host);
                    break;

                case EMode.WEIGHT:
                    host.CurrentMode = new WeightMode(host);
                    break;

                case EMode.TEMPERATURE:
                    host.CurrentMode = new TemperatureMode(host);
                    break;

                default:
                    throw new ArgumentOutOfRangeException("Bad value for _mode");
            }
        }

        public double ConvertUnit()
        {
            throw new NotImplementedException();
        }

        public abstract override string ToString();
    }
}
