using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using OOP_labs.Shapes;
using JsonProperty = System.Text.Json.JsonProperty;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace OOP_Labs.JsonParser
{
    public class JsonConverter
    {
        private const string Extension = ".json";
        public void Serialize(List<IShape> shapes, string fileName, string folderPath, bool rewrite)
        {
            string file;
           
            if (Directory.Exists(folderPath))
            {
                Console.WriteLine("exists");
                file = Path.Combine(folderPath, fileName+ Extension);
                if(! File.Exists(file) || rewrite)
                    File.Create(file);
            }
            else
                throw new FileNotFoundException("Directory does not exists!");
            
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                writer.WriteStartObject();
                foreach (var shape in shapes)
                {
                  
                    writer.WriteStartArray();
                    foreach (var value in shape.ToJson())
                    {
                        writer.WriteValue(value);
                    }
                    writer.WriteEnd();
                }
                writer.WriteEndObject();
                try
                {
                    File.WriteAllText(file, sb.ToString());
                }
                catch (Exception error)
                {
                    throw new FileLoadException("Cannot open the file for writing.");
                }
            }
           
        }

        public void Deserialize(string jsonfile, string folderName)
        {
            ReadOnlySpan<byte> json = new ReadOnlySpan<byte>();
            try
            {
                string file = Path.Combine(folderName, jsonfile + Extension);
                json = File.ReadAllBytes(file);
            }
            catch
            {
                Console.WriteLine("oops...");
                throw new FileNotFoundException($"File {jsonfile} was not find!");
            }
            var reader = new Utf8JsonReader(json);
            while (reader.Read())
            {
               
                if (reader.TokenType == JsonTokenType.PropertyName)
                {
                    string str = reader.GetString();
                    switch (str)
                    {
                        case "Circle":
                            //str.
                            
                           
                            break;
                        case "Rectangle":
                            Console.WriteLine("Rectangle!");
                            break;
                        case "Triangle":
                            Console.WriteLine("Triangle!");
                            break;
                        case "Square":
                            Console.WriteLine("Square!");
                            break;
                    }
                }

            }
           
        }
       
    }

   
}