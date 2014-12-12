
namespace Serialize
{
    interface ISerializer
    {   
        byte[] Serialize(Car obj);
        Car Deserialize(byte[] buff);
    }
}
