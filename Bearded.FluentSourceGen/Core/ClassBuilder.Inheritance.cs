using System;
using System.Collections.Generic;

namespace Bearded.FluentSourceGen;

public sealed partial class ClassBuilder
{
    private readonly List<Type> interfaces = new();

    public ClassBuilder ImplementInterface<T>() => ImplementInterface(typeof(T));

    public ClassBuilder ImplementInterface(Type type)
    {
        interfaces.Add(type);
        return this;
    }
}
