using System.Runtime.CompilerServices;
using DiffEngine;
using VerifyTests;

namespace Bearded.FluentSourceGen.Tests;

public static class StaticConfig
{
    public static readonly VerifySettings DefaultVerifySettings;

    static StaticConfig()
    {
        DefaultVerifySettings = new VerifySettings();
        DefaultVerifySettings.UseDirectory("goldens");
        DefaultVerifySettings.UseExtension("cs");
    }

    [ModuleInitializer]
    public static void Initialize()
    {
        DiffTools.UseOrder(DiffTool.Rider, DiffTool.VisualStudioCode);
    }
}
