using System;
/*
 * Conversion library for Software Testing Project 
 * 
 * Written by Matthew Hall and James McKenzie
 * 
 * May 2020
 * 
 * All written code falls under the GPL3 license
 */

namespace UnitConverter
{
    public static class ConversionMethods
    /*
     * @param _inoutValue The Value to convert from
     * 
     * @return the specified values conversion
     */
    {
        /*
         *cm <-> meter conversions
         */
        public static double mToCm(double _inputValue)
        {
            return _inputValue * 100;
        }
        public static double cmTom(double _inputValue)
        {
            return _inputValue / 100;
        }

        /*
        *cm <-> mm conversions
        */
        public static double mmToCm(double _inputValue)
        {
            return _inputValue * 10;
        }
        public static double cmTomm(double _inputValue)
        {
            return _inputValue / 10;
        }

        /*
        *mm <-> meter conversions
        */
        public static double mTomm(double _inputValue)
        {
            return _inputValue * 1000;
        }
        public static double mmTom(double _inputValue)
        {
            return _inputValue / 1000;
        }


        /*
         * inch <-> m conversions
         */
        public static double mToInch(double _inputValue)
        {
            return _inputValue / 0.0254;
        }
        public static double inchTom(double _inputValue)
        {
            return _inputValue * 0.0254;
        }

        /*
         * inch <-> mm conversions
         */
        public static double mmToInch(double _inputValue)
        {
            return _inputValue / 25.4;
        }
        public static double inchTomm(double _inputValue)
        {
            return _inputValue * 25.4;
        }

        /*
        * inch <-> cm conversions
        */
        public static double cmToInch(double _inputValue)
        {
            return _inputValue / 2.54;
        }
        public static double inchTocm(double _inputValue)
        {
            return _inputValue * 2.54;
        }

        /* Temperature Conversions */


        /*
         * K <-> C conversions 
         */
        public static double kToC(double _inputVale)
        {
            return _inputVale - 273.15;
        }
        public static double cToK(double _inputVale)
        {
            return _inputVale + 273.15;
        }

        /*
         * F <-> C conversions 
         */
        public static double fToC(double _inputVale)
        {
            return (_inputVale - 32) * (5.0 / 9.0);
        }
        public static double cToF(double _inputVale)
        {
            return (_inputVale * (9.0 / 5.0)) + 32;
        }

        /*
        *K <-> F conversions 
        */
        public static double kToF(double _inputVale)
        {
            return (_inputVale * (9.0 / 5.0)) + 32 - 273.15;
        }
        public static double fToK(double _inputVale)
        {
            return (_inputVale - 32) * (5.0 / 9.0) + 273.15;
        }


        /* Weight Conversions */


        /*
         * g <-> lb conversions 
         */
        public static double gTolb(double _inputValue)
        {
            return _inputValue / 453.592;
        }
        public static double lbTog(double _inputValue)
        {
            return _inputValue * 453.592;
        }

        /*
         * stone <-> lb conversions 
         */
        public static double stoneTolb(double _inputValue)
        {
            return _inputValue * 14.0;
        }
        public static double lbToStone(double _inputVale)
        {
            return _inputVale / 14.0;
        }

        /*
         * g <-> stone conversions 
         */
        public static double stoneTog(double _inputValue)
        {
            return _inputValue * 6350.29;
        }
        public static double gToStone(double _inputValue)
        {
            return _inputValue / 6350.29;
        }
    }
}