using System;
using System.Collections.Generic;

namespace Bearded.FluentSourceGen;

public sealed partial class ClassBuilder
{
    private readonly List<ConstructorBuilder> constructors = new();

    public ClassBuilder AddConstructor(Action<ConstructorBuilder> buildFunction)
    {
        var builder = new ConstructorBuilder(className);
        buildFunction(builder);
        constructors.Add(builder);
        return this;
    }
}
