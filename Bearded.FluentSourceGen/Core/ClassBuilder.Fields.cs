using System.Collections.Generic;

namespace Bearded.FluentSourceGen;

public sealed partial class ClassBuilder
{
    // TODO: we should probably have some sort of BuiltField type and not use the reference to store field properties
    private readonly List<IFieldReference> fields = new();

    public ClassBuilder AddField<T>(string name, out FieldReference<T> fieldReference)
    {
        fieldReference = new FieldReference<T>(name);
        fields.Add(fieldReference);
        return this;
    }
}
