using System;

namespace OOP_labs.Shapes
{   /// <summary>
    /// Represents a simple circle for area & perimeter calc
    /// </summary>
    public class Circle:IShape
    {
        private readonly double R;

        public Circle(double radius)
        {
            if(radius<=0)
                throw new ArgumentException("Radius must be a positive number!");
            R = radius;
        }

        public double CalcArea()
        {
            return Math.PI * Math.Pow(R, 2);
        }

        public double CalcPerimeter()
        {
            return 2 * Math.PI * R;
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