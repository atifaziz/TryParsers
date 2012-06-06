The .NET Framework has a number of static `TryParse` methods on types like `int`, `long`, `double`, `DateTime` and so on, that make their use in expressions and functional code like LINQ queries impossible. That's because they return their result in two parts: one in the return value (a `bool` indicating whether the parse was successful) and another in the output parameter (the result of the parse).

TryParsers is a tiny library, which can also be embedded as a single C# file, that turns `TryParse` methods into functions that return their result entirely in the return value. For example, for an `int`, TryParsers's version returns a nullable `int` or `int?`. If the parsing succeeds, the return value will the `int` value otherwise it will be `null`. You can now write error-tolerant code like this:

    var nums = 
        from input in new[] { "O", "l", "2", "3", "4", "S", "6", "7", "B", "9" }
        select TryParse.Int32(input) into num
        where num != null
        select num.Value;
        
    Array.ForEach(nums.ToArray(), Console.WriteLine);

TryParsers is available as two NuGet packages:

 - [TryParsers][1]: library
 - [TryParsers.Embedded][2]: single C# file for private embedding in a project


  [1]: https://nuget.org/packages/TryParsers
  [2]: https://nuget.org/packages/TryParsers.Embedded