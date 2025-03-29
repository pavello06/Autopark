using Autopark.CarTypes;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Autopark.Serializarion
{
    internal class CarConverter : JsonConverter<Car>
    {
        public override Car Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);
            var jsonObject = doc.RootElement;

            var type = jsonObject.GetProperty("$type").GetString();
            Assembly[] allAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            Type[] allTypes = allAssemblies
                .SelectMany(assembly =>
                {
                    try
                    {
                        return assembly.GetTypes();
                    }
                    catch (ReflectionTypeLoadException ex)
                    {
                        return ex.Types.Where(t => t != null);
                    }
                })
                .ToArray()!;
            if (type != null)
            {
                var carType = allTypes.FirstOrDefault(t => t.Name == type);
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
                        writer.WritePropertyName(property.Name);
                        JsonSerializer.Serialize(writer, obj, options);
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

    internal static class Serialization
    {
        private static JsonSerializerOptions options;
        private static XmlSerializer formatter;

        static Serialization()
        {
            options = new JsonSerializerOptions
            {
                Converters = { new CarConverter() },
                WriteIndented = true
            };

            Assembly[] allAssemblies = AppDomain.CurrentDomain.GetAssemblies();
            Type[] allTypes = allAssemblies
                .SelectMany(assembly =>
                {
                    try
                    {
                        return assembly.GetTypes();
                    }
                    catch (ReflectionTypeLoadException ex)
                    {
                        return ex.Types.Where(t => t != null);
                    }
                })
                .ToArray()!;
            var baseClassType = typeof(Car);
            List<Type> types = new List<Type>();
            foreach (var type in allTypes)
            {
                if (!type.IsAbstract && baseClassType.IsAssignableFrom(type))
                {
                    types.Add(type);
                }
            }
            formatter = new XmlSerializer(typeof(List<Car>), types.ToArray());
        }

        public static void Serialize(string fileName)
        {
            using var fileStream = File.Create(fileName);
            if (fileName.EndsWith(".json"))
            {
                JsonSerializer.Serialize(fileStream, Program.Cars!.CarsList, options);
            }
            else
            {       
                formatter.Serialize(fileStream, Program.Cars!.CarsList);
            }
        }

        public static void Deserialize(string fileName)
        {
            using var fileStream = File.Create(fileName);
            if (fileName.EndsWith(".json"))
            {
                if (JsonSerializer.Deserialize(fileStream, typeof(List<Car>), options) is List<Car> list)
                {
                    Program.Cars!.CarsList = list;
                    Program.Cars!.UpdateView();
                    Program.Cars!.UpdateHistory();
                }
            }
            else
            {
                if (formatter.Deserialize(fileStream) is List<Car> list)
                {
                    Program.Cars!.CarsList = list;
                    Program.Cars!.UpdateView();
                    Program.Cars!.UpdateHistory();
                }
            }
        }
    }
}
