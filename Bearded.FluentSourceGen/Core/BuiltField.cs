namespace Bearded.FluentSourceGen;

sealed record BuiltField<T>(string Name, MemberVisibility Visibility)
    : BuiltMember<T>(Name, Visibility),
        IBuiltField
{
    public FieldReference<T> Reference => new(Name);
}
