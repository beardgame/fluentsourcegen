using System.Linq;
using System.Text;
using Bearded.FluentSourceGen.Utilities;

namespace Bearded.FluentSourceGen;

public sealed partial class ClassBuilder
{
    public string ToSourceString()
    {
        var sb = new StringBuilder();

        // TODO: indentation
        sb.AppendLine($"class {className}");
        sb.AppendLine("{");

        foreach (var fieldLine in fields.Select(toSourceString))
        {
            sb.AppendLine(fieldLine);
        }

        sb.AppendLine();

        foreach (var ctor in constructors)
        {
            sb.Append(ctor.ToSourceString());
            sb.AppendLine();
        }

        sb.TrimEnd();
        sb.AppendLine();
        sb.AppendLine("}");

        return sb.ToString();
    }

    private static string toSourceString(IFieldReference fieldReference)
    {
        return $"private static {fieldReference.Type.Name} {fieldReference.Name};";
    }
}
