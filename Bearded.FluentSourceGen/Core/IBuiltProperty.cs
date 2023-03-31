namespace Bearded.FluentSourceGen;

interface IBuiltProperty : IBuiltMember
{
    IFieldReference WrappedField { get; }
}
