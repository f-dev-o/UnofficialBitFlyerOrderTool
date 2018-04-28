using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;

public static class JsonUtility
{
    /// <summary>
    /// 任意のオブジェクトを JSON メッセージへシリアライズします。
    /// </summary>
    public static string Serialize(object graph)
    {
        if (graph == null) return null;

        using (var stream = new MemoryStream())
        {
            var serializer = new DataContractJsonSerializer(graph.GetType());
            serializer.WriteObject(stream, graph);
            return Encoding.UTF8.GetString(stream.ToArray());
        }
    }

    /// <summary>
    /// Jsonメッセージをオブジェクトへデシリアライズします。
    /// </summary>
    public static T Deserialize<T>(string message)
    {
        if (message == null || message.Length == 0) return default(T);
        using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(message)))
        {
            var setting = new DataContractJsonSerializerSettings()
            {
                //UseSimpleDictionaryFormat = true,
            };
            var serializer = new DataContractJsonSerializer(typeof(T), setting);
            return (T)serializer.ReadObject(stream);
        }
    }
}