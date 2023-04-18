using Bearded.FluentSourceGen.Utilities;

namespace Bearded.FluentSourceGen;

sealed partial class FileBuilder
{
    public string ToSourceString()
    {
        var sb = SourceFileBuilder.NewSourceFileBuilder();

        if (fileNamespace is { } ns)
        {
            // TODO: support namespace blocks rather than file-scoped namespaces
            sb.AddExpression($"namespace {ns};");
            sb.AddEmptyLine();
        }

        foreach (var c in classes)
        {
            c.AppendSourceToFile(sb);
            sb.AddEmptyLine();
        }

        sb.TrimEnd();
        return sb.ToSourceString();
    }
}
