﻿using System;
using System.Windows.Forms;
using Microsoft.Xna.Framework;

namespace _3DRadSpace
{
    static public class _3DRadSpace_EditorClass
    {
        /// <summary>
        /// Checks if a dot is in a square's interior
        /// </summary>
        /// <param name="dot">The Point coordinates.</param>
        /// <param name="a">Square up-left corner</param>
        /// <param name="b">Square down-right corner</param>
        /// <returns></returns>
        public static bool DotInSquare(Vector2 dot, Vector2 a, Vector2 b)
        {
            if (a.X <= dot.X && dot.X <= b.X && a.Y <= dot.Y && dot.Y <= b.Y)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Checks if a dot is in a square's interior
        /// </summary>
        /// <param name="dot">The Point coordinates.</param>
        /// <param name="a">Square up-left corner</param>
        /// <param name="b">Square down-right corner</param>
        /// <returns></returns>
        public static bool DotInSquare(Point dot, Point a, Point b) //this one uses Points instead of 2D Vectors.
        {
            if (a.X <= dot.X && dot.X <= b.X && a.Y <= dot.Y && dot.Y <= b.Y)
            {
                return true;
            }
            else return false;
        }
        public static void ValidateNumberFields(string arg)
        {
            float result;
            try
            {
                result = Convert.ToSingle(arg);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid argument", "Error");
                result = 0;
            }
        }
    }
}
