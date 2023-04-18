using System;
using System.Linq;

namespace Bearded.FluentSourceGen.Utilities;

static class TypeFormatter
{
    public static string ToSourceString(this Type type)
    {
        if (type.FullName == null)
        {
            throw new InvalidOperationException("Cannot generate source string for type without full name.");
        }

        if (type.GenericTypeArguments.Length == 0)
        {
            return type.FullName;
        }

        var baseName = type.FullName.Split('`')[0];
        var genericTypeArguments = type.GenericTypeArguments.Select(t => t.ToSourceString());
        var concatenatedTypeArguments = string.Join(", ", genericTypeArguments);

        return $"{baseName}<{concatenatedTypeArguments}>";
    }
}
