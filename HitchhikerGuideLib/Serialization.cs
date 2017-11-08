using System.IO;
using System.Xml.Serialization;

namespace HitchhikerGuide
{
    public static class SerializationExtensions
    {
        public static string ToSerializedXml<T>(this T input)
        {
            using (var writer = new StringWriter())
            {
                input.ToXml(writer);
                return writer.ToString();
            }
        }

        private static void ToXml<T>(this T objectToSerialize, StringWriter writer)
        {
            new XmlSerializer(typeof(T)).Serialize(writer, objectToSerialize);
        }

        public static void ToXml<T>(this T objectToSerialize, Stream stream)
        {
            new XmlSerializer(typeof(T)).Serialize(stream, objectToSerialize);
        }

        public static T Deserialize<T>(this string xml)
        {
            var xmlSerializer = new XmlSerializer(typeof(T));
            var textReader = new StringReader(xml);
            return (T)xmlSerializer.Deserialize(textReader);
        }


    }
}
