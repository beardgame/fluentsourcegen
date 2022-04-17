# Bearded.FluentSourceGen
[![Build & Test [.NET Core]](https://github.com/beardgame/fluentsourcegen/actions/workflows/dotnet-build.yml/badge.svg)](https://github.com/beardgame/fluentsourcegen/actions/workflows/dotnet-build.yml)

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
This library follows the [default contribution guidelines](https://github.com/beardgame/.github/CONTRIBUTING.md) from the beardgame organisation. In addition, PRs created for this library are expected to:

* include at least one test that demonstrates the new feature in use through a golden;
* update the unreleased section in the [changelog](CHANGELOG.md).

Before starting your contribution, first check if there is an issue for the feature you are building. If it is assigned, communicate with the assignee to avoid double work; if not, assign the issue to yourself. Use the issue to describe your intended implementation approach. This can help reduce churn in the code review phase, after you have already spent a lot of time on writing code. If no issue is present, you can create a draft PR from an empty branch (`git commit --allow-empty -m "[description of your feature]"`) instead.

## Releases
This project releases regularly following the versioning system as outlined in the [Semantic Versioning](https://semver.org/spec/v2.0.0.html) standard. Prerelease versions are numbered using the suffix `-dev.#`.
