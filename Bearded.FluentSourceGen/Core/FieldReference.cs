using System;

namespace Bearded.FluentSourceGen;

public sealed class FieldReference<T> : FieldReference
{
    internal FieldReference(string name) : base(name, typeof(T)) { }
}

public class FieldReference : IFieldReference
{
    public string Name { get; }
    public Type Type { get; }

    internal FieldReference(string name, Type type)
    {
        Name = name;
        Type = type;
    }
}
