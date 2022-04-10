namespace Bearded.FluentSourceGen;

public abstract partial class MethodBuilderBase<TMethodBuilder> where TMethodBuilder : MethodBuilderBase<TMethodBuilder>
{
    protected abstract TMethodBuilder This { get; }
}
