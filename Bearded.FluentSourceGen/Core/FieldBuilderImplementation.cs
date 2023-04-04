namespace Bearded.FluentSourceGen;

public abstract class FieldBuilderImplementation<TFieldBuilder>
    where TFieldBuilder : FieldBuilderImplementation<TFieldBuilder>
{
    protected string Name { get; }
    protected MemberVisibility Visibility { get; private set; } = MemberVisibility.Private;

    protected abstract TFieldBuilder This { get; }

    protected FieldBuilderImplementation(string name)
    {
        Name = name;
    }

    public TFieldBuilder WithVisibility(MemberVisibility visibility)
    {
        Visibility = visibility;
        return This;
    }
}
