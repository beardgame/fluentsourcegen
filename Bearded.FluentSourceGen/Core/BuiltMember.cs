using System;

namespace Bearded.FluentSourceGen;

abstract record BuiltMember<T>(string Name, MemberVisibility Visibility) : BuiltMember(Name, typeof(T), Visibility);

abstract record BuiltMember(string Name, Type Type, MemberVisibility Visibility) : IBuiltMember;
