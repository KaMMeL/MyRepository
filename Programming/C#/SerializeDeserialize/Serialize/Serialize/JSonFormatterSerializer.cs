using System.IO;
using System.Runtime.Serialization.Json;

namespace Serialize
{
    class JSonFormatterSerializer : ISerializer
    {
        public byte[] Serialize(Car obj)
        {
            using (var memStr = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(typeof(Car));
                serializer.WriteObject(memStr, obj);
                return memStr.ToArray();
            }
        }

        public Car Deserialize(byte[] buff)
        {
            using (var memStr = new MemoryStream(buff))
            {
                var serializer = new DataContractJsonSerializer(typeof(Car));
                return (Car)serializer.ReadObject(memStr);
            }
        }
    }
}
