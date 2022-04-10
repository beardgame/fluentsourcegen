using System.Collections.Generic;

namespace Bearded.FluentSourceGen;

public abstract partial class MethodBuilderBase<TMethodBuilder>
{
    private readonly List<SourceExpression> expressions = new();

    public TMethodBuilder AddExpression(SourceExpression expression)
    {
        expressions.Add(expression);
        return This;
    }
}
