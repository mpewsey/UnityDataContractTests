using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class ListDataContract<T>
{
    [DataMember]
    public List<T> List { get; set; }
}
