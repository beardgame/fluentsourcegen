using System;

namespace Bearded.FluentSourceGen;

static class MemberVisibilities
{
    public static string ToSourceString(this MemberVisibility visibility) => visibility switch
    {
        MemberVisibility.Public => "public",
        MemberVisibility.ProtectedInternal => "protected internal",
        MemberVisibility.Protected => "protected",
        MemberVisibility.Internal => "internal",
        MemberVisibility.PrivateProtected => "private protected",
        MemberVisibility.Private => "private",
        _ => throw new ArgumentOutOfRangeException(nameof(visibility), visibility, null)
    };
}
