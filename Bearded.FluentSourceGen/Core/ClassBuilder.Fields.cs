using System;
using System.Collections.Generic;

namespace Bearded.FluentSourceGen;

public sealed partial class ClassBuilder
{
    private readonly List<IBuiltField> fields = new();

    public ClassBuilder AddField<T>(string name, out FieldReference<T> fieldReference)
    {
        return AddField(name, b => b, out fieldReference);
    }

    public ClassBuilder AddField<T>(
        string name, Func<FieldBuilder<T>, FieldBuilder<T>> builderFunc, out FieldReference<T> fieldReference)
    {
        var builder = FieldBuilder.NewFieldBuilder<T>(name);
        builder = builderFunc(builder);
        var built = builder.Build();
        fields.Add(built);
        fieldReference = built.Reference;
        return this;
    }
}
