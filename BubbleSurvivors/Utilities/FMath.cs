using Microsoft.Xna.Framework;
using Nez;
using System;

namespace BubbleSurvivors.Utilities
{
    public static class FMath
    {
        public static float PI => (float)Math.PI;


        public static bool Approximately(Vector2 a, Vector2 b, float tolerance = 0.001f)
        {
            return Mathf.Approximately(a.X, b.X, tolerance) && Mathf.Approximately(a.Y, b.Y, tolerance);
        }

        public static Vector2 Approach(Vector2 start, Vector2 end, float shift)
        {
            start.X = Mathf.Approach(start.X, end.X, shift);
            start.Y = Mathf.Approach(start.Y, end.Y, shift);
            return start;
        }

        public static Vector2 RotateVector(Vector2 vec, float angle)
        {
            return new Vector2((vec.X * Mathf.Cos(angle)) - (vec.Y * Mathf.Sin(angle)),
                    (vec.X * Mathf.Sin(angle)) + (vec.Y * Mathf.Cos(angle)));
        }

        public static float Percentage(float value, float min, float max)
        {
            return (value - min) / (max - min);
        }
    }
}
