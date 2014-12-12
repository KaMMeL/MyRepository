using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialize
{
    class XmlFormatterSerializer : ISerializer
    {
        public byte[] Serialize(Car obj)
        {
            using (var memStr = new MemoryStream())
            {
                var serializer = new XmlSerializer(typeof(Car));
                serializer.Serialize(memStr, obj);
                return memStr.ToArray();
            }
        }

        public Car Deserialize(byte[] buff)
        {
            using (var memStr = new MemoryStream(buff))
            {
                var serializer = new XmlSerializer(typeof(Car));
                return (Car)serializer.Deserialize(memStr);
            }
            
        }
    }
}
