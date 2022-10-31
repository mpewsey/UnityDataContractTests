using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class EnumerableDataContract<T>
{
    public List<T> List { get; set; }

    [DataMember]
    public IEnumerable<T> Enumerable { get => List; set => List = new List<T>(value); }
}
