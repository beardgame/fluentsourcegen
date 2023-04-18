namespace Bearded.FluentSourceGen;

public sealed partial class FileBuilder
{
    public static FileBuilder NewFileBuilder(string fileName)
    {
        return new FileBuilder(fileName);
    }

    private readonly string fileName;
    private string? fileNamespace;

    private FileBuilder(string fileName)
    {
        this.fileName = fileName;
    }

    public FileBuilder SetNamespace(string ns)
    {
        fileNamespace = ns;
        return this;
    }
}
