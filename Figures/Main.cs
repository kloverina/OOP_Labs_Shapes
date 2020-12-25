using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using OOP.JsonParser;
using OOP_labs.Shapes;

namespace OOP_Labs
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<IShape>()
            {
                new Square(4),
                new Triangle(3, 4, 5),
                new Circle(7),
                new Rectangle(8, 12)
            };

            
            var folder = "C:/Users/Кристина/RiderProjects/OOP_labs/Figures/JsonParser";
            
            //serializing list of figures to json file
            //JsonParser.Serialize(list, "figures", folder, false);
            
            //deserializing figures from json file
            var checkDeserialize = JsonParser.Deserialize(
                @"C:/Users/Кристина/RiderProjects/OOP_labs/Figures/JsonParser/figures.json");
            foreach (var figure in checkDeserialize)
            {
                Console.WriteLine(figure.ToString());
            }





        }
    }
}