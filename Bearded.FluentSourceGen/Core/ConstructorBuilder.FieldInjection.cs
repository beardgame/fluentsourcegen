namespace Bearded.FluentSourceGen;

public sealed partial class ConstructorBuilder
{
    public ConstructorBuilder InjectFields(params IFieldReference[] fields)
    {
        foreach (var field in fields)
        {
            AddParameter(field.Name, field.Type, out var parameterReference);
            // TODO: this shouldn't be string-based
            AddExpression(SourceExpression.FromSource($"this.{field.Name} = {parameterReference.Name};"));
        }

        return this;
    }
}
