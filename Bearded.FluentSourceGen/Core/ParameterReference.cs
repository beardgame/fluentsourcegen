using System;

namespace Bearded.FluentSourceGen;

public sealed class ParameterReference<T> : IParameterReference
{
    public string Name { get; }
    public Type Type => typeof(T);

    internal ParameterReference(string name)
    {
        Name = name;
    }
}

public sealed class ParameterReference : IParameterReference
{
    public string Name { get; }
    public Type Type { get; }

    internal ParameterReference(string name, Type type)
    {
        Name = name;
        Type = type;
    }
}
