namespace Bearded.FluentSourceGen;

public sealed partial class ConstructorBuilder : MethodBuilderBase<ConstructorBuilder>
{
    protected override ConstructorBuilder This => this;

    private readonly string className;

    public ConstructorBuilder(string className)
    {
        this.className = className;
    }

    protected override string ToSignatureString()
    {
        // TODO: shouldn't always be public
        return $"public {className}";
    }
}
