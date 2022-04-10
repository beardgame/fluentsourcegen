namespace Bearded.FluentSourceGen;

public sealed class SourceExpression
{
    public static SourceExpression FromSource(string source) => new(source);

    private readonly string source;

    private SourceExpression(string source)
    {
        this.source = source;
    }

    public string ToSourceString() => source;
}
