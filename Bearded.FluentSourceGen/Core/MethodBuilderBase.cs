namespace Bearded.FluentSourceGen;

public abstract partial class MethodBuilderBase<TMethodBuilder> where TMethodBuilder : MethodBuilderBase<TMethodBuilder>
{
    protected abstract TMethodBuilder This { get; }

    protected MemberVisibility Visibility { get; private set; } = MemberVisibility.Private;

    public TMethodBuilder WithVisibility(MemberVisibility visibility)
    {
        Visibility = visibility;
        return This;
    }
}
