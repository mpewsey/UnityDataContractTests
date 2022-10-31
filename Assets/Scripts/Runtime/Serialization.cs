using System.IO;
using System.Runtime.Serialization;

public static class Serialization
{
    public static void SaveXml<T>(string path, T graph)
    {
        var serializer = new DataContractSerializer(typeof(T));

        using (var stream = File.Create(path))
        {
            serializer.WriteObject(stream, graph);
        }
    }

    public static T LoadXml<T>(string path)
    {
        var serializer = new DataContractSerializer(typeof(T));

        using (var stream = File.OpenRead(path))
        {
            return (T)serializer.ReadObject(stream);
        }
    }
}
