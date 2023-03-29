using System;

namespace Bearded.FluentSourceGen;

sealed record BuiltField<T>(string Name, MemberVisibility Visibility) : IBuiltField
{
    public Type Type => typeof(T);
    public FieldReference<T> Reference => new(Name);
}
