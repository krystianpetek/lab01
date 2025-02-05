﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Figury
{    public class Point : Figure, IEquatable<Point>
    {
        public readonly double X, Y;
        public Point(double x = 0.0, double y = 0.0)
        {
            this.X = Math.Round(x, Figure.FRACTIONAL_DIGITS);
            this.Y = Math.Round(y, Figure.FRACTIONAL_DIGITS);
            Color = Color.Blue;
        }
        public override string ToString() => $"Point({X},{Y})";
        public override void Draw()
        {
            Console.WriteLine("drawing: " + $"{this.Label} (x={this.X}, y={this.Y}), {Color}");
        }
        #region implementation of IEquatable<Point>
        // https://docs.microsoft.com/en-us/dotnet/api/system.object.equals?view=netstandard-2.0
        public bool Equals(Point other) => (other is null) ? false : (this.X == other.X && this.Y == other.Y);
        public override bool Equals(Object obj)
        {
            if (!this.GetType().Equals(obj.GetType())) return false;
            return this.Equals((Point)obj);
        }
        static public bool operator ==(Point p1, Point p2)
        {
            if (p1 is null && p2 is null) return true;
            if (p1 is null && !(p2 is null)) return false;
            //p1 != null
            return p1.Equals(p2);
        }
        static public bool operator !=(Point p1, Point p2) => !(p1 == p2);
        public override int GetHashCode() => unchecked( ((int) X << 2) ^ (int) Y );
        #endregion
    }
}
