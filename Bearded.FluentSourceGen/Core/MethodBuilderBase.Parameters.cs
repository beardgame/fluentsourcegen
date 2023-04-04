using System;
using System.Collections.Generic;

namespace Bearded.FluentSourceGen;

public abstract partial class MethodBuilderBase<TMethodBuilder>
{
    private readonly List<IParameterReference> parameters = new();

    public TMethodBuilder AddParameter<T>(string name, out ParameterReference<T> parameterReference)
    {
        parameterReference = new ParameterReference<T>(name);
        parameters.Add(parameterReference);
        return This;
    }

    public TMethodBuilder AddParameter(string name, Type type, out IParameterReference parameterReference)
    {
        parameterReference = new ParameterReference(name, type);
        parameters.Add(parameterReference);
        return This;
    }
}
