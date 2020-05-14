﻿using System;

public class ConversionMethods
{
	public ConversionMethods()
	{


	}


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
     * inch conversions
     */
     public static double mToInch(double _inputValue)
    {
        return _inputValue / 0.0254;
    }
    public static double inchTom(double _inputValue)
    {
        return _inputValue * 0.0254;
    }
    public static double mmToInch(double _inputValue)
    {
        return _inputValue / 25.4;
    }
    public static double inchTomm(double _inputValue)
    {
        return _inputValue * 25.4;
    }
    public static double cmToInch(double _inputValue)
    {
        return _inputValue / 2.54;
    }
    public static double inchTocm(double _inputValue)
    {
        return _inputValue * 2.54;
    }

    /* Temperature Conversions */

    public static double kToC (double _inputVale)
    {
        return _inputVale - 273.15;
    }
    public static double cToK(double _inputVale)
    {
        return _inputVale + 273.15;
    }
    public static double fToC(double _inputVale)
    {
        return (_inputVale - 32) * (5.0 / 9.0);
    }
    public static double cToF(double _inputVale)
    {
        return (_inputVale * (9.0 / 5.0)) + 32;
    }
    public static double kToF(double _inputVale)
    {
        return (_inputVale * (9.0 / 5.0)) + 32 - 273.15;
    }
    public static double fToK(double _inputVale)
    {
        return (_inputVale - 32) * (5.0 / 9.0) + 273.15;
    }


    /* Weight Conversions */
        /* g lb kg */
    public static double  gTolb(double _inputValue)
    {
        return _inputValue / 453.592;
    }   
    public static double stoneTolb (double _inputValue)
    {
        return _inputValue * 14.0;
    }
    public static double lbTog(double _inputValue)
    {
        return _inputValue * 453.592;
    }
    public static double lbToStone(double _inputVale)
    {
        return _inputVale / 14.0;
    }
    public static double stoneTog(double _inputValue)
    {
        return _inputValue * 6350.29;
    }

    public static double gToStone(double _inputValue)
    {
        return _inputValue / 6350.29;
    }





    public static void test()
    {
    }


    
}
