using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Numerics;

namespace OOP_labs.Shapes

{
    public enum ShapeType
    {
        Circle    = 0,
        Square   = 1,
        Rectangle = 2,
        Triangle  = 3
    };
    public interface IShape
    { 
        double CalcArea(); 
        double CalcPerimeter();
        List<double> ToJson();

    }

    
}
