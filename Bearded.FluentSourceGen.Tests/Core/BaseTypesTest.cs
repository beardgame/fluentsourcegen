using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VerifyXunit;
using Xunit;
using static Bearded.FluentSourceGen.Tests.StaticConfig;

namespace Bearded.FluentSourceGen.Tests;

[UsesVerify]
public sealed class BaseTypesTest
{
    [Fact]
    public Task InterfaceTest()
    {
        // TODO: make this a valid implementation once we have method generation.
        var source = FileBuilder.NewFileBuilder("MyClass.cs")
            .SetNamespace("Bearded.FluentSourceGen.Golden")
            .AddClass("MyClass", c => c
                .ImplementInterface<IDisposable>())
            .ToSourceString();

        return Verifier.Verify(source, settings: DefaultVerifySettings, extension: "cs");
    }

    [Fact]
    public Task MultipleInterfacesTest()
    {
        // TODO: make this a valid implementation once we have method generation.
        var source = FileBuilder.NewFileBuilder("MyClass.cs")
            .SetNamespace("Bearded.FluentSourceGen.Golden")
            .AddClass("MyClass", c => c
                .ImplementInterface(typeof(IDisposable))
                .ImplementInterface(typeof(IFormattable)))
            .ToSourceString();

        return Verifier.Verify(source, settings: DefaultVerifySettings, extension: "cs");
    }

    [Fact]
    public Task GenericInterfaceTest()
    {
        // TODO: make this a valid implementation once we have method generation.
        var source = FileBuilder.NewFileBuilder("MyClass.cs")
            .SetNamespace("Bearded.FluentSourceGen.Golden")
            .AddClass("MyClass", c => c
                .ImplementInterface<IComparer<object>>())
            .ToSourceString();

        return Verifier.Verify(source, settings: DefaultVerifySettings, extension: "cs");
    }
}
