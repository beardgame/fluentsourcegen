using System;

namespace Bearded.FluentSourceGen;

public sealed class FieldReference<T> : IFieldReference
{
    public string Name { get; }
    public Type Type => typeof(T);

    internal FieldReference(string name)
    {
        Name = name;
    }
}
