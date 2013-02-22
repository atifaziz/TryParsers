TryParsers is available as two NuGet packages:

 - [TryParsers][1]: library
 - [TryParsers.Embedded][2]: C# source for private embedding in a project

The .NET Framework has a number of static `TryParse` methods on types like [`Int32`][3], [`Int64`][4], [`Double`][5], [`DateTime`][6] and so on, that make their use in expressions and functional code like LINQ queries impossible. That's because they return their result in two parts: one in the return value (a Boolean indicating whether the parse was successful) and another in an output parameter (the parsed value).

TryParsers is a tiny library, which can also be embedded as one or two C# files, that turns `TryParse` methods into functions that return their result entirely in the return value. For example, for an `Int32`, TryParsers's version returns a [nullable][7] `Int32` or simply `int?` in C#. If the parsing succeeds, the return value will be the parsed `Int32` value otherwise it will be `null`.

You can now write error-tolerant code using LINQ like this:

    var nums = 
        from input in new[] { "O", "l", "2", "3", "4", "S", "6", "7", "B", "9" }
        select TryParse.Int32(input) into num
        where num != null
        select num.Value;
        
    Console.WriteLine(string.Join(",", nums);
    
    // Output: 2,3,4,6,7,9

The .NET Framework still has many types that support parsing or initializing from a string representation of a value but which throw exceptions on failure. TryParsers also comes with a generic method called `Make` for such cases that enables building a `TryParse`-like method on top of existing parsers. For example, the [`MailAddress`][8] [constructor][9] throws [`FormatException`][10] when it fails to parse or recognize a valid e-mail address. Using `Make`, however, you can create a `TryParse`-like method on top of `MailAddress`:

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

Note that `Make` above will still throw if an exception other than `FormatException` is thrown by the `MailAddress` constructor. Below is a more advanced of example using `Make` to distinguish between `FormatException` and `OverflowException` (throwing in all other cases):

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

Download and install TryParsers from NuGet:

 - [TryParsers][1]: library
 - [TryParsers.Embedded][2]: C# source for private embedding in a project


  [1]: https://nuget.org/packages/TryParsers
  [2]: https://nuget.org/packages/TryParsers.Embedded
  [3]: http://msdn.microsoft.com/en-us/library/system.int32.tryparse.aspx
  [4]: http://msdn.microsoft.com/en-us/library/system.int64.tryparse.aspx
  [5]: http://msdn.microsoft.com/en-us/library/system.double.tryparse.aspx
  [6]: http://msdn.microsoft.com/en-us/library/system.datetime.tryparse.aspx
  [7]: http://msdn.microsoft.com/en-us/library/system.nullable.aspx
  [8]: http://msdn.microsoft.com/en-us/library/system.net.mail.mailaddress.aspx
  [9]: http://msdn.microsoft.com/en-us/library/591bk9e8.aspx
  [10]: http://msdn.microsoft.com/en-us/library/system.formatexception.aspx
