namespace Bearded.FluentSourceGen;

public sealed class FieldBuilder<T>
{
    private readonly string name;
    private MemberVisibility visibility = MemberVisibility.Private;

    internal FieldBuilder(string name)
    {
        this.name = name;
    }

    public FieldBuilder<T> WithVisibility(MemberVisibility visibility)
    {
        this.visibility = visibility;
        return this;
    }

    internal BuiltField<T> Build()
    {
        return new BuiltField<T>(name, visibility);
    }
}

public static class FieldBuilder
{
    public static FieldBuilder<T> NewFieldBuilder<T>(string name)
    {
        return new FieldBuilder<T>(name);
    }
}
