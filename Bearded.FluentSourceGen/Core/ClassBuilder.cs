namespace Bearded.FluentSourceGen;

public sealed partial class ClassBuilder
{
    public static ClassBuilder NewClassBuilder(string name)
    {
        return new ClassBuilder(name);
    }

    private readonly string className;

    private ClassBuilder(string className)
    {
        this.className = className;
    }
}
