## TryParsers

TryParse is a .NET Standard library that provides methods for _attempting
parsing_ of basic values without the need for output parameters, as most
[`TryParse`][dotnet-try-parse] method do in .NET.

It is available as two NuGet packages:

 - [TryParsers][pkg]: library
 - ~~[TryParsers.Embedded][srcpkg]: C# source for private embedding in
   a project~~ (deprecated)

The .NET Standard has a number of static `TryParse` methods on types like
[`Int32`][int], [`Int64`][long], [`Double`][double], [`DateTime`][dt] and so
on, that make their use in expressions and functional code like LINQ queries
impossible. That's because they return their result in two parts: one in the
return value (a Boolean indicating whether the parse was successful) and
another in an output parameter (the parsed value).

TryParsers is a tiny library, which can also be embedded as one or two C#
files, that turns `TryParse` methods into functions that return their result
entirely in the return value. For example, for an `Int32`, TryParsers's
version returns a [nullable][nullable] `Int32` or simply `int?` in C#. If
the parsing succeeds, the return value will be the parsed `Int32` value
otherwise it will be `null`.

You can now write error-tolerant code using LINQ like this:

```c#
var nums =
    from input in new[] { "O", "l", "2", "3", "4", "S", "6", "7", "B", "9" }
    select TryParse.Int32(input) into num
    where num != null
    select num.Value;

Console.WriteLine(string.Join(",", nums);

// Output: 2,3,4,6,7,9
```

The .NET Standard still has many types that support parsing or initializing
from a string representation of a value but which throw exceptions on failure.
TryParsers also comes with a generic method called `Make` for such cases that
enables building a `TryParse`-like method on top of existing parsers. For
example, the [`MailAddress`][MailAddress] [constructor][MailAddress.ctor]
throws [`FormatException`][FormatException] when it fails to parse or
recognize a valid e-mail address. Using `Make`, however, you can create a
`TryParse`-like method on top of `MailAddress`:

```c#
var addresses =
    from parser in new[] {
        TryParse.Make(s => new MailAddress(s), (FormatException e) => null)
    }
    from s in new[] {
        "john.doe@example.com",
        "john-dot-doe-at-example-dot-com",
        "john.doe@localhost",
    }
    select parser(s) into address
    where address != null
    select address;

Console.WriteLine(string.Join("; ", addresses));

// Output:
// john.doe@example.com; john.doe@localhost
```

Note that `Make` above will still throw if an exception other than
`FormatException` is thrown by the `MailAddress` constructor. Below is a more
advanced of example using `Make` to distinguish between `FormatException` and
`OverflowException` (throwing in all other cases):

```c#
var results =
    from parser in new[] {
        TryParse.Make(s => (object) sbyte.Parse(s, NumberStyles.None),
                        (FormatException e)   => e,
                        (OverflowException e) => e)
    }
    from s in new[] {  "l",  "2",   "4",  "B",    "16",
                      "32", "64", "128", "256", "-512"  }
    select parser(s) into e
    select e is OverflowException
         ? "#OVERFLOW"
         : e is FormatException
         ? "#ERROR"
         : e;

Console.WriteLine(string.Join(",", results));

// Output:
// #ERROR,2,4,#ERROR,16,32,64,#OVERFLOW,#OVERFLOW,#ERROR
```

Download and install TryParsers from NuGet:

 - [TryParsers][pkg]: library
 - ~~[TryParsers.Embedded][srcpkg]: C# source for private embedding in a project~~ (deprecated)


[pkg]: https://nuget.org/packages/TryParsers
[srcpkg]: https://nuget.org/packages/TryParsers.Embedded
[int]: http://msdn.microsoft.com/en-us/library/system.int32.tryparse.aspx
[long]: http://msdn.microsoft.com/en-us/library/system.int64.tryparse.aspx
[double]: http://msdn.microsoft.com/en-us/library/system.double.tryparse.aspx
[dt]: http://msdn.microsoft.com/en-us/library/system.datetime.tryparse.aspx
[nullable]: http://msdn.microsoft.com/en-us/library/system.nullable.aspx
[MailAddress]: http://msdn.microsoft.com/en-us/library/system.net.mail.mailaddress.aspx
[MailAddress.ctor]: http://msdn.microsoft.com/en-us/library/591bk9e8.aspx
[FormatException]: http://msdn.microsoft.com/en-us/library/system.formatexception.aspx
[dotnet-try-parse]: https://source.dot.net/#q=TryParse
