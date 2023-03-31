using System;

namespace Bearded.FluentSourceGen;

interface IBuiltMember
{
    string Name { get; }
    Type Type { get; }
    MemberVisibility Visibility { get; }
}
