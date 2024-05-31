# C# guide

## CLI: Command Line Interface

```bash
dotnet new <template> -o <outputProjectName>
```

To get templates list just type `dotnet new` in the terminal and check the shortnames.

```bash
dotnet run
```

## File Structure

- **bin**: Contains the compiled files. (Not included in the repository.)
- **obj**: Contains the intermediate files. (Not included in the repository.)
- **Program.cs**: The main file where the program starts.
- **.csproj**: The project file that contains the project configuration.

## Syntax

`class.method(input parameters);`

**Code compilation errors occur when:**

- Entering lower-case letters instead of capitalizing `C` in `Console`, or the letters `W` or `L` in `WriteLine`. (C# is case-sensitive and code lines are written with CamelCase.)
- Entering a `,` (comma) instead of a `.` (period) between `Console` and `WriteLine`.
- Forgetting to use `"` (double-quotation marks), or using `'` (single-quotation marks) to surround the phrase *Hello World!*.
- Forgetting a `;` (semi-colon) at the end of the command. (The code instructions were executed in order, one line at a time.)

## Comments

- `//` for single-line comments.
- `/* */` for multi-line comments.

## Output (console)

```csharp
Console.WriteLine("print text to the console WITH line-break at the end.");
Console.Write("print text to the console WITHOUT line-break.");
```

## Variables

- Variable names can contain alphanumeric characters and the underscore character.
- Variable names should begin with an alphabetical letter (not a number). Use the underscore as start for a special purpose*.
- Variable names are case-sensitive, meaning that `string Value;` and `string value;` are two different variables.
- Variable names must not be a C# keyword. For example, you cannot use the following variable declarations: `decimal decimal;` or `string string;`.
- Variable names should use camelCase.
- Variable names should be descriptive and meaningful in your app. Choose a name for your variable that represents the kind of data it will hold.
- Variable names should be one or more entire words appended together. Don't use contractions or abbreviations because the name of the variable (and therefore, its purpose) may be unclear to others who are reading your code.
- Variable names shouldn't include the data type of the variable. You might see some advice to use a style like string strValue;. That advice is no longer current.

```csharp
var implicityTypedVariable = "Hello World!";
string explicitlyTypedVariable = "Hello World!";
```

- Initialize a variable = declare + assign a value.
- There is no hoisting in C#.
- Variables can be reassigned.
- Data types cannot be changed after the variable is declared.

## DataTypes

1. **(presenting one alphanumeric) Character** - `char`: `'a'` or `'\u0061'` (Unicode) or `'\x61'` (hexadecimal).
2. **(presenting string of characters) String** - `string`: `"Hello World!"`.
3. **(whole number) Integer** - `int`: `42`.
4. **(whole number) Long** - `long`: `42L`.
5. **(floating-point number) Float** - `float`: `42.42f` (Precision: ~6-9 digits).
6. **(floating-point number) Double** - `double`: `42.42` (Precision: ~15-17 digits).
7. **(floating-point number) Decimal** - `decimal`: `42.42m` (Precision: 28-29 digits).
8. **(true or false) Boolean** - `bool`: `true` or `false`.

### String (literals)

#### escape character sequences

- `\'` - single quote.
- `\"` - double quote.
- `\\` - backslash.
- `\0` - null.
- `\a` - alert.
- `\b` - backspace.
- `\f` - form feed.
- `\n` - new line.
- `\r` - carriage return.
- `\t` - horizontal tab.
- `\u` - Unicode (UTF-16) escape sequence.
- `\v` - vertical tab.
- `@` - verbatim string literal. It will keep all whitespace and characters without the need to escape the backslash.

```csharp
Console.WriteLine(@"    c:\source\repos
        (this is where your code goes)");
```

#### Concatenation & Interpolation (template literals)

```csharp
string firstName = "John";
string lastName = "Doe";
string fullName = firstName + " " + lastName;
string fullNameInterpolation = $"{firstName} {lastName}";
Console.WriteLine($@"C:\Output\{fullName}\Data");
```

### Numbers

Operations use PEMDAS (Parentheses, Exponents, Multiplication and Division, Addition and Subtraction):

- `()` Brackets.
- `**` Indices (exponentiation).
- `/` Division.
- `*` Multiplication.
- `+` Addition.
- `-` Subtraction.
- `%` Modulus (remainder).
- `++` Increment.
- `--` Decrement.
- `+=` Addition assignment.
- `-=` Subtraction assignment.
- `*=` Multiplication assignment.
- `/=` Division assignment.
- `%=` Modulus assignment.

If you use the Increment/Decrement operator before the value as `++value`, then the increment will happen before the value is retrieved. Likewise, `value++` will increment the value after the value has been retrieved.

Cast `int` to `decimal` in a calculation:

```csharp
int a = 10;
int b = 3;
decimal c = (decimal)a / b;
// OR
decimal a = 10.0m;
decimal b = 3.0m;
decimal c = a / b;
```

If we have remainer in a division with `int` (or implicit `int`) the result won't be rounded.
