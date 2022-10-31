using System;
using System.Runtime.Serialization;

[DataContract]
public struct StructDataContract : IEquatable<StructDataContract>
{
    [DataMember]
    public float X { get; set; }

    [DataMember]
    public float Y { get; set; }

    [DataMember]
    public float Z { get; set; }

    public override bool Equals(object obj)
    {
        return obj is StructDataContract contract && Equals(contract);
    }

    public bool Equals(StructDataContract other)
    {
        return X == other.X &&
               Y == other.Y &&
               Z == other.Z;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(X, Y, Z);
    }

    public static bool operator ==(StructDataContract left, StructDataContract right)
    {
        return left.Equals(right);
    }

    public static bool operator !=(StructDataContract left, StructDataContract right)
    {
        return !(left == right);
    }
}
