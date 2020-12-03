using System;

namespace OOP_labs.Shapes
{
    /// <summary>
    /// Represents a simple rectangle for area & perimeter calc.
    /// </summary>
    /// /// Constructor creates a rectangle from 2 different sides: width and height
    public class Rectangle: IShape
    {
        private readonly double A;
        private readonly double B;

        public Rectangle(double width, double height)
        {
            if (width<=0 || height<=0)
                throw new ArgumentException("Error! Sides of a figure must be a positive number!");
            A = width;
            B = height;
        }

        public double CalcArea() {
            return A * B;
        }

        public double CalcPerimeter() {
            return (A + B) * 2;
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (other.GetType() != this.GetType()) 
                return false;

            return this.Equals(other as Rectangle);
        }

        private bool Equals(Rectangle other)
        {
            if (A.Equals(A)) return false;
            if (B.Equals(B)) return false;
            return true;
        }
        
        public override int GetHashCode()
        {
            var result = A.GetHashCode();
            result = 31 * result + B.GetHashCode();
            return result;
        }

        public override string ToString()
        {
            return $"Rectangle: width = {A}, height ={B}";
        }
    }
}