namespace Bearded.FluentSourceGen;

public sealed partial class ConstructorBuilder : MethodBuilderBase<ConstructorBuilder>
{
    protected override ConstructorBuilder This => this;

    private readonly string className;

    public ConstructorBuilder(string className)
    {
        this.className = className;
        WithVisibility(MemberVisibility.Public);
    }

    protected override string ToSignatureString()
    {
        return $"{Visibility.ToSourceString()} {className}";
    }
}
