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
        var source = FileBuilder.NewFileBuilder("MyClass.cs")
            .SetNamespace("Bearded.FluentSourceGen.Golden")
            .AddClass("MyClass", c => c
                .AddField<int>("myInt", out var intFieldReference)
                .AddField<string>("myString", out var stringFieldReference)
                .AddConstructor(ctor => ctor.InjectFields(intFieldReference, stringFieldReference)))
            .ToSourceString();

        return Verifier.Verify(source, settings: DefaultVerifySettings, extension: "cs");
    }
}
