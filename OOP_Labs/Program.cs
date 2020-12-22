using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using OOP_labs.Shapes;
using OOP_Labs.JsonParser;

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

            var json = new JsonParser.JsonParser();
            var folder = "C:/Users/Кристина/RiderProjects/OOP_labs/OOP_Labs/JsonParser";
            
            //serializing list of figures to json file
            JsonParser.JsonParser.Serialize(list, "figures", folder, false);
            
            //deserializing figures from json file
            var checkDeserialize = JsonParser.JsonParser.Deserialize("figures", folder);
            foreach (var figure in checkDeserialize)
            {
                Console.WriteLine(figure.ToString());
            }





        }
    }
}