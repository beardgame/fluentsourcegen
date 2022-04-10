using System.Linq;
using System.Text;

namespace Bearded.FluentSourceGen;

public abstract partial class MethodBuilderBase<TMethodBuilder>
{
    protected abstract string ToSignatureString();

    public string ToSourceString()
    {
        var sb = new StringBuilder();

        sb.Append(ToSignatureString());
        sb.Append('(');

        sb.AppendJoin(", ", parameters.Select(p => $"{p.Type.Name} {p.Name}"));

        sb.Append(')');
        sb.AppendLine();
        // TODO: indentation
        sb.AppendLine("{");

        foreach (var sourceExpression in expressions)
        {
            sb.AppendLine(sourceExpression.ToSourceString());
        }

        sb.AppendLine("}");

        return sb.ToString();
    }
}
