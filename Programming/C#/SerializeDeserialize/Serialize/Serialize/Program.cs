using System;

namespace Serialize
{
    class Program
    {
        private static ISerializer _ser;
        private static Car _carr;
        private static byte[] _byteObj;
        static void Main()
        {
            var car = new Car();
            car.Mark = "Mercedes";
            car.Model = "SLK";

            _ser = new BinaryFormatterSerializer();
            _byteObj = _ser.Serialize(car);
            _carr = _ser.Deserialize(_byteObj);
            _carr.GetData();

            _ser = new XmlFormatterSerializer();
            _byteObj = _ser.Serialize(car);
            _carr = _ser.Deserialize(_byteObj);
            _carr.GetData();


            _ser = new JSonFormatterSerializer();
            _byteObj = _ser.Serialize(car);
            _carr = _ser.Deserialize(_byteObj);
            _carr.GetData();

            Console.ReadKey();
        }
    }
}
