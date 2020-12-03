using System;

namespace OOP_labs.Shapes
{
    /// <summary>
    /// Represents a simple triangle for area & perimeter calc
    /// </summary>
    /// <exception cref="ArithmeticException">
    /// throws [exception] when triangle with given sides cannot exists
    /// </exception>
    public class Triangle:IShape
    {
        private readonly double A;
        private readonly double B;
        private readonly double C;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC<=0)
                throw new ArgumentException("Sides of triangle must be a positive number!");
            if(sideA + sideB < sideC || sideA + sideC < sideB || sideB + sideC < sideA)
                throw new ArithmeticException("Triangle with given sides cannot exists!");
            A = sideA;
            B = sideB;
            C = sideC;
        }
        public double CalcArea()
        {
            var p = CalcPerimeter() / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C)); //Heron's formula for triangles
        }
        
        public double CalcPerimeter()
        {
            return A + B + C;
        }

        public override string ToString()
        {
            return $"Triangle: A = {A}, B = {B}, C = {C}";
        }

        public override bool Equals(object other)
        {
            if (other == null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            if (this.GetType() != other.GetType())
                return false;
            return this.Equals(other as Triangle);
        }

        private bool Equals(Triangle other)
        {
            return A.Equals(other.A) && B.Equals(other.B) && C.Equals(other.C);
        }

        public override int GetHashCode()
        {
            var hashCode = A.GetHashCode();
            hashCode = hashCode * 31 + B.GetHashCode();
            hashCode = hashCode * 31 + C.GetHashCode();
            return hashCode;
        }
    }
}