using System;

namespace Bearded.FluentSourceGen;

public sealed class PropertyReference<T> : IPropertyReference
{
    public string Name { get; }
    public Type Type => typeof(T);

    internal PropertyReference(string name)
    {
        Name = name;
    }
}
