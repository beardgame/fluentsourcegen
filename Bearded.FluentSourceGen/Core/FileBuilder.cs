namespace Bearded.FluentSourceGen;

sealed partial class FileBuilder
{
    public static FileBuilder NewFileBuilder(string fileName)
    {
        return new FileBuilder(fileName);
    }

    private readonly string fileName;

    private FileBuilder(string fileName)
    {
        this.fileName = fileName;
    }
}
