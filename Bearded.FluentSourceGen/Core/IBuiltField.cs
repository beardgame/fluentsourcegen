using System;

namespace Bearded.FluentSourceGen;

interface IBuiltField
{
    string Name { get; }
    Type Type { get; }
    MemberVisibility Visibility { get; }
}
