using System.Threading.Tasks;
using VerifyXunit;
using Xunit;
using static Bearded.FluentSourceGen.Tests.StaticConfig;

namespace Bearded.FluentSourceGen.Tests;

[UsesVerify]
public sealed class AutoPropertyTest
{
    [Fact]
    public Task AutoGetterTest()
    {
        var source = FileBuilder.NewFileBuilder("MyClass.cs")
            .SetNamespace("Bearded.FluentSourceGen.Golden")
            .AddClass("MyClass", c => c
                .AddField<int>("myInt", out var intFieldReference)
                .AddAutoGetter("MyInt", MemberVisibility.Public, intFieldReference, out _))
            .ToSourceString();

        return Verifier.Verify(source, settings: DefaultVerifySettings, extension: "cs");
    }
}
