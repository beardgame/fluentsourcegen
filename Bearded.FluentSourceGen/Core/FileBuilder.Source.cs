using Bearded.FluentSourceGen.Utilities;

namespace Bearded.FluentSourceGen;

sealed partial class FileBuilder
{
    public string ToSourceString()
    {
        var sb = SourceFileBuilder.NewSourceFileBuilder();
        foreach (var c in classes)
        {
            c.AppendSourceToFile(sb);
            sb.AddEmptyLine();
        }

        sb.TrimEnd();
        return sb.ToSourceString();
    }
}
