using System;

namespace Bearded.FluentSourceGen;

abstract record BuiltMember<T>(string Name, MemberVisibility Visibility) : IBuiltMember
{
    public Type Type => typeof(T);
}
