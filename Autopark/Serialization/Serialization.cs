using Autopark.CarTypes;
using System.Reflection;
using System.Text.Json;
using System.Xml.Serialization;

using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Autopark.Serialization
{
    public class CarConverter : System.Text.Json.Serialization.JsonConverter<Car>
    {
        public override Car Read(ref Utf8JsonReader reader, System.Type typeToConvert, JsonSerializerOptions options)
        {
            using JsonDocument doc = JsonDocument.ParseValue(ref reader);
            var jsonObject = doc.RootElement;

            var type = jsonObject.GetProperty("@xsi:type").GetString();
            System.Type[] allTypes = Autopark.Type.Type.GetTypes();
            if (type != null)
            {
                var carType = allTypes.FirstOrDefault(t => t.Name == type);
                var rawJson = jsonObject.GetRawText();

                var optionsWithConverter = new JsonSerializerOptions
                {
                    Converters =
                    {
                        new StringToNumberConverter<int>(),
                        new StringToNumberConverter<uint>(),
                        new StringToNumberConverter<double>(),
                        new StringToNumberConverter<float>(),
                        new StringToNumberConverter<EngineType>()
                    }
                };

                if (System.Text.Json.JsonSerializer.Deserialize(rawJson, carType!, optionsWithConverter) is Car car)
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

            writer.WriteString("@xsi:type", value.GetType().Name);
            foreach (var property in carType.GetProperties())
            {
                if (property.GetValue(value) is object obj)
                {
                    if (property.PropertyType == typeof(Engine))
                    {
                        writer.WritePropertyName(property.Name);
                        System.Text.Json.JsonSerializer.Serialize(writer, obj, options);
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

    public class StringToNumberConverter<T> : System.Text.Json.Serialization.JsonConverter<T>
    {
        public override T Read(ref Utf8JsonReader reader, System.Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                var stringValue = reader.GetString();

                if (typeof(T) == typeof(int) && int.TryParse(stringValue, out var intValue))
                {
                    return (T)(object)intValue;
                }
                if (typeof(T) == typeof(uint) && uint.TryParse(stringValue, out var uintValue))
                {
                    return (T)(object)uintValue;
                }
                if (typeof(T) == typeof(double) && double.TryParse(stringValue, out var doubleValue))
                {
                    return (T)(object)doubleValue;
                }
                if (typeof(T) == typeof(float) && float.TryParse(stringValue, out var floatValue))
                {
                    return (T)(object)floatValue;
                }
                if (typeof(T) == typeof(EngineType))
                {
                    return (T)(object)(EngineType)Enum.Parse(typeof(EngineType), (stringValue!));
                }
            }

            return JsonSerializer.Deserialize<T>(ref reader)!;
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, options);
        }
    }

    public static class Serialization
    {
        public delegate void ExtraSerialize(Cars cars, FileStream fileStream);
        public delegate void ExtraDeserialize(Cars cars, FileStream fileStream);

        public static ExtraSerialize? extraSerialize = null;
        public static ExtraDeserialize? extraDeserialize = null;

        public static JsonSerializerOptions options;
        public static XmlSerializer formatter;

        static Serialization()
        {
            options = new JsonSerializerOptions
            {
                Converters = { new CarConverter() },
                WriteIndented = true
            };

            System.Type[] allTypes = Type.Type.GetTypes();
            var baseClassType = typeof(Car);
            List<System.Type> types = new List<System.Type>();
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
                if (extraSerialize == null)
                {
                    System.Text.Json.JsonSerializer.Serialize(fileStream, Program.Cars!.CarsList, options);
                }
                else
                {
                    extraSerialize(Program.Cars!, fileStream);
                }
            }
            else
            {
                formatter.Serialize(fileStream, Program.Cars!.CarsList);
            }
        }

        public static void Deserialize(string fileName)
        {
            using var fileStream = File.Open(fileName, FileMode.Open);
            if (fileName.EndsWith(".json"))
            {
                if (System.Text.Json.JsonSerializer.Deserialize(fileStream, typeof(List<Car>), options) is List<Car> list)
                {
                    Program.Cars!.CarsList = list;
                    Program.Cars!.UpdateView();
                    Program.Cars!.UpdateHistory();
                }
            }
            else
            {
                if (extraSerialize == null)
                {
                    if (formatter.Deserialize(fileStream) is List<Car> list)
                    {
                        Program.Cars!.CarsList = list;
                        Program.Cars!.UpdateView();
                        Program.Cars!.UpdateHistory();
                    }
                }
                else
                {
                    extraDeserialize!(Program.Cars!, fileStream);                   
                }
            }
        }
    }
}