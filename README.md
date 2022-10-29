# Bearded.FluentSourceGen
[![Build & Test](https://github.com/beardgame/fluentsourcegen/actions/workflows/dotnet-build.yml/badge.svg)](https://github.com/beardgame/fluentsourcegen/actions/workflows/dotnet-build.yml)

Bearded.FluentSourceGen is a library that can be used to write source generation code for C# using a type safe, fluent interface. This prevents authors of source generators having to use string manupulation to output their source. Using this fluent interface brings several advantages over using string manipulation:

* The interface is type safe, which catched bugs in the code you will generate before it is even generated!
* Refactoring the generated code would require rewriting a lot of strings from scratch, whereas with fluent source generation, it's (almost) as easy as refactoring code you wrote yourself!
* The library can handle several details for you like variable or class names that are not part of the public interface.
* The generated code from this library automatically applies good code practices (sealed classes, readonly structs), unless you specifically give it a reason to override those.

Because an example says more than 1000 words, consider the following code snippet:

```csharp
NewClassBuilder("MyClass")
    .AddField<int>("myInt", out var intFieldReference)
    .AddField<string>("myString", out var stringFieldReference)
    .AddField<bool>("derivedBool", out var boolFieldReference)
    .AddConstructor(ctor => ctor
        .InjectFields(intFieldReference, stringFieldReference)
        .AddParameter<double>("myDouble", out _)
        .AssignField(boolFieldReference, Expression.FromString("myDouble > 0.5")))
    .ToSourceString();
```

The output of this snippet would look something like:

```csharp
sealed class MyClass
{
    private readonly int myInt;
    private readonly string myString;
    private readonly bool derivedBool;

    public MyClass(int myInt, string myString, double myDouble)
    {
        this.myInt = myInt;
        this.myString = myString;
        this.derivedBool = myDouble > 0.5;
    }
}
```

## State of the library
This library is currently under **heavy development**. Many parts of this library do not have all functionality yet, and we expect public interfaces to change over time as we converge on a final workable MVP. PRs in this state are welcome, but it is recommended you follow the contributing guidelines below to help us move in the overall direction we are hoping to go in.

## Contributing
See <CONTRIBUTING.md>.

## Releases
This project releases regularly following the versioning system as outlined in the [Semantic Versioning](https://semver.org/spec/v2.0.0.html) standard. Prerelease versions are numbered using the suffix `-dev.#`.
