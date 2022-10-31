using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class DictionaryDataContract<TKey, TValue>
{
    [DataMember]
    public Dictionary<TKey, TValue> Dictionary { get; set; }
}
