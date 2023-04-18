using System;
using System.Collections.Generic;

namespace Bearded.FluentSourceGen;

public sealed partial class FileBuilder
{
    // TODO: this should ideally have built classes instead, but for that we need built methods first
    private readonly List<ClassBuilder> classes = new();

    public FileBuilder AddClass(string name, Action<ClassBuilder> buildFunction)
    {
        var builder = ClassBuilder.NewClassBuilder(name);
        buildFunction(builder);
        classes.Add(builder);
        return this;
    }
}
