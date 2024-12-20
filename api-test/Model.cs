using System.Runtime.Serialization;

namespace api_test;

[DataContract, Serializable]
public class Model
{
    [DataMember] public int Id { get; init; }
    [DataMember] public string Name { get; init; }
    [DataMember] public string Description { get; init; }
    [DataMember] public int Price { get; init; }
    [DataMember] public int Quantity { get; init; }
    [DataMember] public string Category { get; init; }
    [DataMember] public bool Availability { get; init; }
    [DataMember] public List<string> Tags { get; init; }
}