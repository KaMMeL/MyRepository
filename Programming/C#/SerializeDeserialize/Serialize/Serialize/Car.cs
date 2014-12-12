using System;
using System.Runtime.Serialization;

namespace Serialize
{
    
    [Serializable]
    [DataContract]
    public class Car
    {
        [DataMember]
        public string Mark { get; set; }
        [DataMember]
        public string Model { get; set; }

        public void GetData()
        {
            Console.WriteLine(this.Mark + " " + this.Model);
        }
    }
}
