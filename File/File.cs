using Autopark.Objects;
using Autopark.Objects.Race;
using Autopark.Objects.Rare;
using Microsoft.VisualBasic.Logging;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Autopark.File
{
    internal class CarConverter : JsonConverter<Car>
    {
        public override Car Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);
            var jsonObject = doc.RootElement;

            var type = jsonObject.GetProperty("$type").GetString();
            var assembly = Assembly.GetExecutingAssembly();
            if (type != null)
            {
                var carType = assembly.GetTypes().FirstOrDefault(t => t.Name == type);
                if (carType != null && JsonSerializer.Deserialize(jsonObject.GetRawText(), carType, options) is Car car)
                {
                    return car;
                }
            }

            throw new Exception("Deserialization error");
        }

        public override void Write(Utf8JsonWriter writer, Car value, JsonSerializerOptions options)
        {
            writer.WriteStartObject();

            var carType = value.GetType();

            writer.WriteString("$type", value.GetType().Name);
            foreach (var property in carType.GetProperties())
            {
                if (property.GetValue(value) is object obj)
                {
                    if (property.PropertyType == typeof(Engine))
                    {
                        writer.WriteStartObject(property.Name);
                        writer.WriteString("Type", obj.ToString());
                        writer.WriteEndObject();
                    }
                    else if (property.PropertyType == typeof(uint))
                    {
                        writer.WriteNumber(property.Name, (uint)obj);
                    }
                    else
                    {
                        writer.WriteString(property.Name, obj.ToString());
                    }
                }
   
            }

            writer.WriteEndObject();
        }
    }

    internal static class File
    {
        public static void Serialize(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (fileName.EndsWith(".json"))
                {
                    var options = new JsonSerializerOptions
                    {
                        Converters = { new CarConverter() },
                        WriteIndented = true 
                    };

                    JsonSerializer.Serialize(fileStream, Program.Cars.CarsList, options);
                }
                else
                {
                    XmlSerializer formatter = new XmlSerializer(typeof(List<Objects.Car>));
                    formatter.Serialize(fileStream, Program.Cars!.CarsList);
                }
            }
        }

        public static void Deserialize(string fileName)
        {
            using (FileStream fileStream = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                if (fileName.EndsWith(".json"))
                {
                    var options = new JsonSerializerOptions
                    {
                        Converters = { new CarConverter() },
                        WriteIndented = true
                    };

                    Program.Cars.CarsList = (List<Car>)JsonSerializer.Deserialize(fileStream, typeof(List<Car>), options);
                    //Program.Cars.UpdateView();
                }
                else
                {
                    //XmlSerializer formatter = new XmlSerializer(typeof(List<List<(string, object)>>));
                    //formatter.Serialize(fileStream, list);
                }
            }
        }
    }
}
