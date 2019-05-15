using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PatternRecognition.FingerprintRecognition.Core
{

    public static class BinarySerializer
    {
        
        public static void Serialize(object obj, string FileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(FileName, FileMode.Create);
            formatter.Serialize(stream, obj);
            stream.Close();
        }

        
        public static byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            Serialize(obj, stream);
            return stream.ToArray();
        }

        public static void Serialize(object obj, Stream stream)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
        }

        public static object Deserialize(Stream stream)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return formatter.Deserialize(stream);
        }

        public static object Deserialize(string fileName)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(fileName, FileMode.Open);
            object Result = formatter.Deserialize(stream);
            stream.Close();
            return Result;
        }

        public static object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            return Deserialize(stream);
        }
    }
}