using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace Serialize
{
    class BinaryFormatterSerializer : ISerializer
    {
        public byte[] Serialize(Car obj)
        {
            using(var memStr = new MemoryStream())
            { 
                var serializer = new BinaryFormatter();
                serializer.Serialize(memStr, obj);
                return memStr.ToArray();
            }
        }

        public Car Deserialize(byte[] buff)
        {
            using (var memStr = new MemoryStream(buff))
            {
                var serializer = new BinaryFormatter();
                return (Car)serializer.Deserialize(memStr);
                
            }
            
        }
    }
}
