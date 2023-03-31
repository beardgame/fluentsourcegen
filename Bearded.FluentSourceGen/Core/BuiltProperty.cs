namespace Bearded.FluentSourceGen;

sealed record BuiltProperty<T>(string Name, MemberVisibility Visibility, FieldReference<T> FieldReference)
    : BuiltMember<T>(Name, Visibility),
        IBuiltProperty
{
    public PropertyReference<T> Reference => new(Name);
    public IFieldReference WrappedField => FieldReference;
}
