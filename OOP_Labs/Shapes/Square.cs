namespace OOP_labs.Shapes
{ 
   /// <summary>
   /// Represents a simple square based on Rectangle class.
   /// </summary>
   /// Constructor creates a square from 1 given side
    public class Square : Rectangle
    {
        private double A;
        public Square(double side) : base(side, side)
        {
            A = side;
        }

        public override string ToString()
        {
            return $"Square: {A}";
        }
    }
}
        
      

    
