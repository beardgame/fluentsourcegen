using System;

namespace Bearded.FluentSourceGen;

public sealed class PropertyReference<T> : PropertyReference
{
    internal PropertyReference(string name) : base(name, typeof(T)) { }
}

public class PropertyReference : IPropertyReference
{
    public string Name { get; }
    public Type Type { get; }

    internal PropertyReference(string name, Type type)
    {
        Name = name;
        Type = type;
    }
}
