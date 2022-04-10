using System;

namespace Bearded.FluentSourceGen;

public class MethodBuilder : MethodBuilderBase<MethodBuilder>
{
    protected override MethodBuilder This => this;

    public static MethodBuilder NewMethodBuilder<T>(string name) => NewMethodBuilder(typeof(T), name);

    public static MethodBuilder NewMethodBuilder(Type returnType, string name)
    {
        return new(returnType, name);
    }

    private readonly Type returnType;
    private readonly string methodName;

    private MethodBuilder(Type returnType, string methodName)
    {
        this.returnType = returnType;
        this.methodName = methodName;
    }

    protected override string ToSignatureString()
    {
        // TODO: shouldn't always be public, or non-static, or...
        return $"public {returnType} {methodName}";
    }
}
