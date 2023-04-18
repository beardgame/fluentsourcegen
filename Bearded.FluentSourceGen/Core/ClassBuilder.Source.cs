using System.Linq;
using Bearded.FluentSourceGen.Utilities;

namespace Bearded.FluentSourceGen;

public sealed partial class ClassBuilder
{
    internal void AppendSourceToFile(SourceFileBuilder builder)
    {
        builder.StartBlock($"class {className}");

        foreach (var fieldLine in fields.Select(toSourceString))
        {
            builder.AddExpression(fieldLine);
        }

        builder.AddEmptyLine();

        foreach (var propertyLine in properties.Select(toSourceString))
        {
            builder.AddExpression(propertyLine);
        }

        foreach (var ctor in constructors)
        {
            ctor.AppendSourceToFile(builder);
            builder.AddEmptyLine();
        }

        builder
            .TrimEnd()
            .EndBlock();
    }

    private static string toSourceString(IBuiltField field)
    {
        return $"{field.Visibility.ToSourceString()} {field.Type.ToSourceString()} {field.Name};";
    }

    private static string toSourceString(IBuiltProperty property)
    {
        return
            $"{property.Visibility.ToSourceString()} {property.Type.ToSourceString()} {property.Name} => {property.WrappedField.Name};";
    }
}
