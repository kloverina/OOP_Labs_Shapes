using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json.Linq;
using OOP_labs.Shapes;


namespace OOP.JsonParser
{
    
    /// <summary>
    /// This class provides the ability to save list of figures to json file
    /// and load figures from json file
    /// </summary>
    /// <remarks>
    /// For correct serialization all figures from [IShape] must have a "toJson" method
    /// </remarks>
    public class JsonParser 
    {
        // Extension for all files with saves data
        private const string Extension = ".json";
        /// <summary>
        /// This method serializes a list of [shapes] into JSON and writes data
        /// to [fileName] file 
        /// </summary>
        /// <param name="shapes"> List that contains  figures to be serialized</param>
        /// <param name="fileName"> Name of file where serialized data would  stored</param>
        /// <param name="folderPath"> Directory to json file</param>
        /// <param name="rewrite">Can overwrite the file if it already exist</param>
        /// <exception cref="FileNotFoundException"> Given directory does not exist</exception>
        /// <exception cref="FileLoadException"> Cannot open a file for writing</exception>
        public static void Serialize(List<IShape> shapes, string fileName, string folderPath, bool rewrite)
        {
            string file;
           
            if (Directory.Exists(folderPath))
            {
                file = Path.Combine(folderPath, fileName+ Extension);
                if(! File.Exists(file))
                    File.Create(file);
            }
            else
                throw new FileNotFoundException("Directory does not exists!");

            SerializeFigures(shapes, file);
        }

        public static void Serialize(List<IShape> shapes, string fileName, bool rewrite)
        {
            string  file = fileName;
             
            if(! File.Exists(file)) 
                File.Create(file);
            
            SerializeFigures(shapes, file);
        }

        private static void SerializeFigures(List<IShape> shapes, string file)
        {
            var json = new JObject();
            //writes the type of shape and array with its values as one JsonElement
            foreach (var shape in shapes)
            {
                var jsArray = new JArray();
                var shapeValues = shape.ToJson();
                jsArray.Add(shapeValues);
                json.Add(shape.GetType().ToString(), jsArray);
            }
            try
            {
                File.WriteAllText(file, json.ToString());
            }
            catch (Exception error)
            {
                throw new FileLoadException("Cannot open the file for writing.");
            }
            
        }

        /// <summary>
        /// Deserializes list of figures from json file and returns list with deserialized data.
        /// </summary>
        /// <param name="fileName">Name of the file with serialized data.</param>
        /// <param name="folderPath">Directory to file with serialized data.</param>
        /// <returns> Deserialized list of [IShape]</returns>
        /// <exception cref="FileNotFoundException">File with given name or directory does not exist.</exception>
        /// <exception cref="FileLoadException">Cannot read from file.</exception>
        public static List<IShape> Deserialize(string fileName, string folderPath)
        {
            JObject jObject;
            try
            {
                string file = Path.Combine(folderPath, fileName + Extension);
                if(!File.Exists(file))
                    throw new FileNotFoundException($"File {fileName} was not found!");
                var json = File.ReadAllText(file);
                jObject = JObject.Parse(json);
              
            }
            catch
            {
                throw new FileLoadException("Error! Cannot read from file!");
            }
            return DeserializeFigures(jObject) ;
        }

        /// <summary>
        /// Deserializes list of figures using a full path to file (path+name of the file)
        /// </summary>
        /// <param name="fullPath">Full path to json file with extension. </param>
        public static List<IShape> Deserialize(string fullPath)
        {
            JObject jObject;
            try
            {
                string file = fullPath;
                if(!File.Exists(file))
                    throw new FileNotFoundException("File was not found!");
                var json = File.ReadAllText(file);
                jObject = JObject.Parse(json);
            }
            catch
            {
                throw new FileLoadException("Error! Cannot read from file!");
            }
            return DeserializeFigures(jObject) ;
        }
        
        /// <summary>
        /// Converts type of figure and its properties from json to [IShape]
        /// </summary>
        private static List<IShape> DeserializeFigures(JObject jObject)
        {
            List<IShape> allFigures = new List<IShape>();
            foreach (var jsonProperty in jObject.Properties())
            {
                var className = jsonProperty.Name;
                List<double> values = new List<double>();
               
                foreach (var value in jObject.GetValue(className))
                {
                    values.Add(value.Value<double>());
                }
                var figureType = Type.GetType(className);
                var figure = (IShape) Activator.CreateInstance(figureType ?? throw new NullReferenceException(), values);
                
                allFigures.Add(figure);
            }
            return allFigures;
        }
    }

    
}