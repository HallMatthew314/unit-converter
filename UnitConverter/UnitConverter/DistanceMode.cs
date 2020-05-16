using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
    public enum EDistances
    {
        Centimetres,
        Millimetres,
        Metres,
        Inches
    }

    public class DistanceMode : Mode
    {
        public DistanceMode(Form1 _host) : base(_host)
        {
            conversions = new Dictionary<int, Dictionary<int, Func<double, double>>>()
            {
                // base unit cm
                {
                    (int)EDistances.Centimetres, new Dictionary<int, Func<double, double>>()
                    {
                        { (int)EDistances.Centimetres, (x) => x },
                        { (int)EDistances.Millimetres, (x) => ConversionMethods.cmTomm(x) },
                        { (int)EDistances.Metres, (x) => ConversionMethods.cmTom(x) },
                        { (int)EDistances.Inches, (x) => ConversionMethods.cmToInch(x) },
                    }
                },
                // base unit mm
                {
                    (int)EDistances.Millimetres, new Dictionary<int, Func<double, double>>()
                    {
                        { (int)EDistances.Centimetres, (x) => ConversionMethods.mmToCm(x) },
                        { (int)EDistances.Millimetres, (x) => x },
                        { (int)EDistances.Metres, (x) => ConversionMethods.mmTom(x) },
                        { (int)EDistances.Inches, (x) => ConversionMethods.mmToInch(x) },
                    }
                },
                // base unit m
                {
                    (int)EDistances.Metres, new Dictionary<int, Func<double, double>>()
                    {
                        { (int)EDistances.Centimetres, (x) => ConversionMethods.mToCm(x) },
                        { (int)EDistances.Millimetres, (x) => ConversionMethods.mTomm(x) },
                        { (int)EDistances.Metres, (x) => x },
                        { (int)EDistances.Inches, (x) => ConversionMethods.mToInch(x) },
                    }
                },
                // base unit inch
                {
                    (int)EDistances.Inches, new Dictionary<int, Func<double, double>>()
                    {
                        { (int)EDistances.Centimetres, (x) => ConversionMethods.inchTocm(x) },
                        { (int)EDistances.Millimetres, (x) => ConversionMethods.inchTomm(x) },
                        { (int)EDistances.Metres, (x) => ConversionMethods.inchTom(x) },
                        { (int)EDistances.Inches, (x) => x },
                    }
                }
            };
        }

        public override Array UnitValues
        {
            get => Enum.GetValues(typeof(EDistances));
        }

        public override string ToString()
        {
            return "Distance Mode";
        }
    }
}
