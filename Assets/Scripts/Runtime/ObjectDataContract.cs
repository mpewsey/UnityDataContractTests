using System.Runtime.Serialization;

[DataContract]
public class ObjectDataContract
{
    [DataMember]
    public float X { get; set; }

    [DataMember]
    public float Y { get; set; }

    [DataMember]
    public float Z { get; set; }
}
