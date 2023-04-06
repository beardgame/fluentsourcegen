using System;

namespace Bearded.FluentSourceGen;

sealed record BuiltProperty<T>(string Name, MemberVisibility Visibility, FieldReference<T> FieldReference)
    : BuiltMember<T>(Name, Visibility),
        IBuiltProperty
{
    public PropertyReference<T> Reference => new(Name);
    public IFieldReference WrappedField => FieldReference;
}

sealed record BuiltProperty(string Name, Type Type, MemberVisibility Visibility, FieldReference FieldReference)
    : BuiltMember(Name, Type, Visibility),
        IBuiltProperty
{
    public PropertyReference Reference => new(Name, Type);
    public IFieldReference WrappedField => FieldReference;
}
