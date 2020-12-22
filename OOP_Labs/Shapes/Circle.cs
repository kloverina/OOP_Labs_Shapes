using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace OOP_labs.Shapes
{   /// <summary>
    /// Represents a simple circle for area & perimeter calc
    /// </summary>
    [Serializable]
    public class Circle:IShape
    {
        [JsonPropertyAttribute] 
        private readonly double R;

        public Circle(double radius)
        {
            if(radius<=0)
                throw new ArgumentException("Radius must be a positive number!");
            R = radius;
        }

        public Circle(List<double> value)
        {
            this.R = value[0];
        }
        public double CalcArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public double CalcPerimeter()
        {
            return 2 * Math.PI * R;
        }

        public List<double> ToJson()
        {
            return new List<double> {R};
        }

        public override string ToString()
        {
            return $"Circle: R = {R}";
        }

        

        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if(ReferenceEquals(this, other))
                return true;
            if (other.GetType() != this.GetType()) 
                return false;

            return this.Equals(other as Circle);
        }
        private bool Equals(Circle other)
        {
            return R.Equals(other.R);
        }

        public override int GetHashCode()
        {
            return R.GetHashCode();
        }
        
        

        
    }
}