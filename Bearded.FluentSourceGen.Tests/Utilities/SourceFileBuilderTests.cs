using System;
using Bearded.FluentSourceGen.Utilities;
using FluentAssertions;
using Xunit;

namespace Bearded.FluentSourceGen.Tests.Utilities;

public sealed class SourceFileBuilderTests
{
    [Fact]
    public void EmptyBuilderOutputsEmptyString()
    {
        var result = SourceFileBuilder.NewSourceFileBuilder()
            .ToSourceString();

        result.Should().BeEmpty();
    }

    [Fact]
    public void BuilderOutputsAddedLines()
    {
        var result = SourceFileBuilder.NewSourceFileBuilder()
            .AddExpression("var a = 1;")
            .AddExpression("var b = a + 1;")
            .ToSourceString();

        result.Should().Be(@"var a = 1;
var b = a + 1;
");
    }

    [Fact]
    public void BuilderOutputBlocks()
    {
        var result = SourceFileBuilder.NewSourceFileBuilder()
            .StartBlock("sealed class MyClass")
            .AddExpression("private int aNumber = 1;")
            .EndBlock()
            .ToSourceString();

        result.Should().Be($@"sealed class MyClass
{{
    private int aNumber = 1;
}}
");
    }

    [Fact]
    public void BuilderOutputsNonIndentedEmptyLines()
    {
        var result = SourceFileBuilder.NewSourceFileBuilder()
            .StartBlock("sealed class MyClass")
            .AddExpression("private int aNumber = 1;")
            .AddEmptyLine()
            .AddExpression("public int AProperty => aNumber;")
            .EndBlock()
            .ToSourceString();

        result.Should().Be($@"sealed class MyClass
{{
    private int aNumber = 1;

    public int AProperty => aNumber;
}}
");
    }

    [Fact]
    public void BuilderOutputsNestedBlocks()
    {
        var result = SourceFileBuilder.NewSourceFileBuilder()
            .StartBlock("sealed class MyClass")
            .AddExpression("private readonly int aNumber;")
            .AddEmptyLine()
            .StartBlock("public MyClass(int aNumber)")
            .AddExpression("this.aNumber = aNumber;")
            .EndBlock()
            .EndBlock()
            .ToSourceString();

        result.Should().Be($@"sealed class MyClass
{{
    private readonly int aNumber;

    public MyClass(int aNumber)
    {{
        this.aNumber = aNumber;
    }}
}}
");
    }

    [Fact]
    public void NonClosedBlocksThrowException()
    {
        var builder = SourceFileBuilder.NewSourceFileBuilder()
            .StartBlock("sealed class MyClass")
            .StartBlock("public MyClass()")
            .EndBlock();

        Action action = () => builder.ToSourceString();

        action.Should().Throw<InvalidOperationException>();
    }
}
