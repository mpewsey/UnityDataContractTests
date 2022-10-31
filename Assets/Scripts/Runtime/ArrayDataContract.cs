using System.Runtime.Serialization;

[DataContract]
public class ArrayDataContract<T>
{
    [DataMember]
    public T[] Array { get; set; }
}
