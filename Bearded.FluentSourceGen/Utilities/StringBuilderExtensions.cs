using System.Text;

namespace Bearded.FluentSourceGen.Utilities;

static class StringBuilderExtensions
{
    public static void TrimEnd(this StringBuilder sb)
    {
        if (sb.Length == 0)
        {
            return;
        }

        var lastNonWhitespaceIndex = sb.Length - 1;
        while (lastNonWhitespaceIndex >= 0 && char.IsWhiteSpace(sb[lastNonWhitespaceIndex]))
        {
            lastNonWhitespaceIndex--;
        }

        if (lastNonWhitespaceIndex < sb.Length - 1)
        {
            sb.Length = lastNonWhitespaceIndex + 1;
        }
    }
}
