using System;
using System.Linq;
using System.Text;

namespace Bearded.FluentSourceGen.Utilities;

sealed class SourceFileBuilder
{
    private const int indentationSize = 4;

    private readonly StringBuilder sb = new();
    private string currentIndentation = "";

    public static SourceFileBuilder NewSourceFileBuilder() => new SourceFileBuilder();

    private SourceFileBuilder() {}

    public SourceFileBuilder AddExpression(string expression)
    {
        return addLine(expression);
    }

    public SourceFileBuilder AddEmptyLine()
    {
        sb.AppendLine();
        return this;
    }

    public SourceFileBuilder StartBlock(string declaration)
    {
        return addLine(declaration).addLine("{").indent();
    }

    public SourceFileBuilder EndBlock()
    {
        return unIndent().addLine("}");
    }

    private SourceFileBuilder indent()
    {
        currentIndentation += string.Join("", Enumerable.Range(0, indentationSize).Select(_ => " "));
        return this;
    }

    private SourceFileBuilder unIndent()
    {
        currentIndentation = currentIndentation[indentationSize..];
        return this;
    }

    private SourceFileBuilder addLine(string line)
    {
        sb.Append(currentIndentation);
        sb.AppendLine(line);
        return this;
    }

    public string ToSourceString()
    {
        if (currentIndentation != string.Empty)
        {
            throw new InvalidOperationException("Cannot generate source string with non-closed blocks");
        }

        return sb.ToString();
    }
}
