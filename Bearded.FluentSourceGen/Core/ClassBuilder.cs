namespace Bearded.FluentSourceGen;
/*

NewClassBuilder()
.AddField<int>("myInt", out var intFieldReference)
.AddField<string>("myString", out var stringFieldReference)
.AddField<bool>("derivedBool", out var boolFieldReference)
.AddConstructor(ctor => ctor
.InjectFields(intFieldReference, stringFieldReference)
.AddParameter<double>("myDouble", out _)
.AssignField(boolFieldReference, Expression.FromString("myDouble > 0.5")))
.ToSourceString();

 */

public sealed partial class ClassBuilder
{
    public static ClassBuilder NewClassBuilder(string name)
    {
        return new(name);
    }

    private readonly string className;

    private ClassBuilder(string className)
    {
        this.className = className;
    }
}
