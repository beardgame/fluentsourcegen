using System.Linq;
using System.Text;
using Bearded.FluentSourceGen.Utilities;

namespace Bearded.FluentSourceGen;

public abstract partial class MethodBuilderBase<TMethodBuilder>
{
    protected abstract string ToSignatureString();

    public string ToSourceString()
    {
        var sb = SourceFileBuilder.NewSourceFileBuilder();
        AppendSourceToFile(sb);
        return sb.ToSourceString();
    }

    internal void AppendSourceToFile(SourceFileBuilder builder)
    {
        var parameterString = string.Join(", ", parameters.Select(p => $"{p.Type.Name} {p.Name}"));
        var fullSignatureString = $"{ToSignatureString()}({parameterString})";

        builder.StartBlock(fullSignatureString);
        foreach (var sourceExpression in expressions)
        {
            builder.AddExpression(sourceExpression.ToSourceString());
        }
        builder.EndBlock();
    }
}
