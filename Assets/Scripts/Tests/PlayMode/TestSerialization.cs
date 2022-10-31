using NUnit.Framework;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class TestSerialization
{
    [SetUp]
    public void SetUp()
    {
        Directory.CreateDirectory("Tests");
    }

    [Test]
    public void TestArrayWithValueTypes()
    {
        var path = "Tests/ArrayWithValueTypes.xml";
        var original = new ArrayDataContract<int>();
        original.Array = new int[] { 1, 2, 3, 4, 5 };
        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<ArrayDataContract<int>>(path);
        CollectionAssert.AreEqual(original.Array, copy.Array);
    }

    [Test]
    public void TestArrayWithStructTypes()
    {
        var path = "Tests/ArrayWithStructTypes.xml";
        var original = new ArrayDataContract<StructDataContract>();

        original.Array = new StructDataContract[]
        {
            new StructDataContract { X = 1, Y = 2, Z = 3 },
            new StructDataContract { X = 4, Y = 5, Z = 6 },
        };

        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<ArrayDataContract<StructDataContract>>(path);
        CollectionAssert.AreEqual(original.Array, copy.Array);
    }

    [Test]
    public void TestArrayWithObjectTypes()
    {
        var path = "Tests/ArrayWithObjectTypes.xml";
        var original = new ArrayDataContract<ObjectDataContract>();

        original.Array = new ObjectDataContract[]
        {
            new ObjectDataContract { X = 1, Y = 2, Z = 3 },
            new ObjectDataContract { X = 4, Y = 5, Z = 6 },
        };

        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<ArrayDataContract<ObjectDataContract>>(path);

        CollectionAssert.AreEqual(original.Array.Select(x => x.X), copy.Array.Select(x => x.X));
        CollectionAssert.AreEqual(original.Array.Select(x => x.Y), copy.Array.Select(x => x.Y));
        CollectionAssert.AreEqual(original.Array.Select(x => x.Z), copy.Array.Select(x => x.Z));
    }

    [Test]
    public void TestListWithValueTypes()
    {
        var path = "Tests/ListWithValueTypes.xml";
        var original = new ListDataContract<int>();
        original.List = new List<int> { 1, 2, 3, 4, 5 };
        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<ListDataContract<int>>(path);
        CollectionAssert.AreEqual(original.List, copy.List);
    }

    [Test]
    public void TestListWithStructTypes()
    {
        var path = "Tests/ListWithStructTypes.xml";
        var original = new ListDataContract<StructDataContract>();

        original.List = new List<StructDataContract>
        {
            new StructDataContract { X = 1, Y = 2, Z = 3 },
            new StructDataContract { X = 4, Y = 5, Z = 6 },
        };

        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<ListDataContract<StructDataContract>>(path);
        CollectionAssert.AreEqual(original.List, copy.List);
    }

    [Test]
    public void TestListWithObjectTypes()
    {
        var path = "Tests/ListWithObjectTypes.xml";
        var original = new ListDataContract<ObjectDataContract>();

        original.List = new List<ObjectDataContract>
        {
            new ObjectDataContract{ X = 1, Y = 2, Z = 3 },
            new ObjectDataContract{ X = 4, Y = 5, Z = 6 },
        };

        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<ListDataContract<ObjectDataContract>>(path);

        CollectionAssert.AreEqual(original.List.Select(x => x.X), copy.List.Select(x => x.X));
        CollectionAssert.AreEqual(original.List.Select(x => x.Y), copy.List.Select(x => x.Y));
        CollectionAssert.AreEqual(original.List.Select(x => x.Z), copy.List.Select(x => x.Z));
    }

    [Test]
    public void TestDictionaryWithValueTypes()
    {
        var path = "Tests/DictionaryWithValueTypes.xml";
        var original = new DictionaryDataContract<int, int>();

        original.Dictionary = new Dictionary<int, int>
        {
            { 1, 2 },
            { 3, 4 },
            { 5, 6 },
        };

        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<DictionaryDataContract<int, int>>(path);

        CollectionAssert.AreEquivalent(original.Dictionary.Keys, copy.Dictionary.Keys);
        CollectionAssert.AreEquivalent(original.Dictionary.Values, copy.Dictionary.Values);
    }

    [Test]
    public void TestDictionaryWithStructTypes()
    {
        var path = "Tests/DictionaryWithStructTypes.xml";
        var original = new DictionaryDataContract<StructDataContract, StructDataContract>();

        original.Dictionary = new Dictionary<StructDataContract, StructDataContract>
        {
            { new StructDataContract { X = 1, Y = 2, Z = 3 }, new StructDataContract { X = 1, Y = 2, Z = 3 } },
            { new StructDataContract { X = 4, Y = 5, Z = 6 }, new StructDataContract { X = 4, Y = 5, Z = 6 } },
        };

        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<DictionaryDataContract<StructDataContract, StructDataContract>>(path);

        CollectionAssert.AreEquivalent(original.Dictionary.Keys, copy.Dictionary.Keys);
        CollectionAssert.AreEquivalent(original.Dictionary.Values, copy.Dictionary.Values);
    }

    [Test]
    public void TestEnumerableWithValueTypes()
    {
        var path = "Tests/EnumerableWithValueTypes.xml";
        var original = new EnumerableDataContract<int>();
        original.List = new List<int> { 1, 2, 3, 4, 5 };
        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<EnumerableDataContract<int>>(path);
        CollectionAssert.AreEqual(original.List, copy.List);
    }

    [Test]
    public void TestEnumerableWithStructTypes()
    {
        var path = "Tests/EnumerableWithStructTypes.xml";
        var original = new EnumerableDataContract<StructDataContract>();

        original.List = new List<StructDataContract>
        {
            new StructDataContract { X = 1, Y = 2, Z = 3 },
            new StructDataContract { X = 4, Y = 5, Z = 6 },
        };

        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<EnumerableDataContract<StructDataContract>>(path);
        CollectionAssert.AreEqual(original.List, copy.List);
    }

    [Test]
    public void TestEnumerableWithObjectTypes()
    {
        var path = "Tests/EnumerableWithObjectTypes.xml";
        var original = new EnumerableDataContract<ObjectDataContract>();

        original.List = new List<ObjectDataContract>
        {
            new ObjectDataContract{ X = 1, Y = 2, Z = 3 },
            new ObjectDataContract{ X = 4, Y = 5, Z = 6 },
        };

        Serialization.SaveXml(path, original);
        var copy = Serialization.LoadXml<EnumerableDataContract<ObjectDataContract>>(path);

        CollectionAssert.AreEqual(original.List.Select(x => x.X), copy.List.Select(x => x.X));
        CollectionAssert.AreEqual(original.List.Select(x => x.Y), copy.List.Select(x => x.Y));
        CollectionAssert.AreEqual(original.List.Select(x => x.Z), copy.List.Select(x => x.Z));
    }
}
