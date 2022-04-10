using System.Threading.Tasks;
using VerifyXunit;
using Xunit;
using static Bearded.FluentSourceGen.Tests.StaticConfig;

namespace Bearded.FluentSourceGen.Tests;

[UsesVerify]
public sealed class FieldInjectionTest
{
    [Fact]
    public Task NamedFieldsTest()
    {
        var source = ClassBuilder.NewClassBuilder("MyClass")
            .AddField<int>("myInt", out var intFieldReference)
            .AddField<string>("myString", out var stringFieldReference)
            .AddConstructor(ctor => ctor.InjectFields(intFieldReference, stringFieldReference))
            .ToSourceString();

        return Verifier.Verify(source, DefaultVerifySettings);
    }
}
