//Part of the Unity Audio System project by Petr Yakyamsev
//github.com/doublereso/Csharp_Unity_Audio_System

using UnityEngine;

namespace AudioCalculations.Properties
{
    public class AudioConvert
    {
        public static float plusOne(float argument)
        {
            return argument + 1.0f;
        }

        public static double FloatToDb(float argument)
        {
            //in Unity they use floats and their own custom log class
            //dB = 20 Log10(x)
            double argumentDouble = argument;
            return (20 * System.Math.Log10(argumentDouble));
        }
        public static double DbToFloat(float argument)
        {
            //in Unity they use floats and their own custom log class
            //x = 10^(dB/20)
            double argumentDouble = argument;
            return System.Math.Pow(10.0, argumentDouble * 0.05);
        }
        public static double FloatToSt(float argument)
        {
            //in Unity they use floats and their own custom log class
            //St = ln(x)/(ln(2^1/12))
            double argumentDouble = argument;
            return System.Math.Log(argumentDouble) / System.Math.Log(System.Math.Pow(2.0, 1.0 / 12.0));
        }
        public static double StToFloat(float argument)
        {
            //in Unity they use floats and their own custom log class
            //x = (2^1/12)^St
            double argumentDouble = argument;
            return System.Math.Pow(System.Math.Pow(2.0, 1.0 / 12.0), argument);
        }

        public static float TempoToSec(int bpm, int tsA, int tsB)
        {
            //in Unity they use floats and their own custom log class
            return (60.0f / (float)bpm) * ((float)tsA / (float)tsB) * 4.0f;
        }


    }
}

