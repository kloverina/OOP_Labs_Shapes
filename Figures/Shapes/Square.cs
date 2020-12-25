using System.Collections.Generic;
using Newtonsoft.Json;

namespace OOP_labs.Shapes
{ 
   /// <summary>
   /// Represents a simple square based on Rectangle class.
   /// </summary>
   /// Constructor creates a square from 1 given side
    public class Square : Rectangle
    {
        
        [JsonProperty]
        private double A;
        public Square(double side) : base(side, side)
        {
            A = side;
        }
        public Square(List<double> value) :base(value)
        {
            this.A = value[0];
        }

        public override string ToString()
        {
            return $"Square: {A}";
        }

        public  List<double> ToJson()
        {
            return new List<double>{A};
        }
        
    }
}
        
      

    
