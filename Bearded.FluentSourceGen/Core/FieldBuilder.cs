using System;

namespace Bearded.FluentSourceGen;

public sealed class FieldBuilder<T> : FieldBuilderImplementation<FieldBuilder<T>>
{
    protected override FieldBuilder<T> This => this;

    internal FieldBuilder(string name) : base(name) { }

    internal BuiltField<T> Build()
    {
        return new BuiltField<T>(Name, Visibility);
    }
}

public sealed class FieldBuilder : FieldBuilderImplementation<FieldBuilder>
{
    private readonly Type type;
    protected override FieldBuilder This => this;

    private FieldBuilder(string name, Type type) : base(name)
    {
        this.type = type;
    }

    internal BuiltField Build()
    {
        return new BuiltField(Name, type, Visibility);
    }

    public static FieldBuilder NewFieldBuilder(string name, Type type)
    {
        return new FieldBuilder(name, type);
    }

    public static FieldBuilder<T> NewFieldBuilder<T>(string name)
    {
        return new FieldBuilder<T>(name);
    }
}
