using System;

namespace Bearded.FluentSourceGen;

public interface IVariableReference
{
    string Name { get; }
    Type Type { get; }
}
