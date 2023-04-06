using System;

namespace Bearded.FluentSourceGen;

sealed record BuiltField<T>(string Name, MemberVisibility Visibility)
    : BuiltMember<T>(Name, Visibility),
        IBuiltField
{
    public FieldReference<T> Reference => new(Name);
}

sealed record BuiltField(string Name, Type Type, MemberVisibility Visibility)
    : BuiltMember(Name, Type, Visibility),
        IBuiltField
{
    public FieldReference Reference => new(Name, Type);
}
