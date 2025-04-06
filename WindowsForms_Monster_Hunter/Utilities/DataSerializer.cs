using System.Text.Json;

namespace Utilities
{
    public class DataSerializer
    {
        public void JsonSerialize<T> (T obj, string filename)
        {
            string jsonString = JsonSerializer.Serialize(obj, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filename, jsonString);
        }

        public T JsonDeserializer<T>(string filename)
        {
            string jsonString = File.ReadAllText(filename);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
