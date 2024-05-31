// STRINGS
string firstName = "Szabolcs";
string lastName = "Hlatky";

/// Concatenation
string fullName = firstName + " Réthalapi " + lastName;

/// Interpolation (template string literals)
string name = $"{firstName} {lastName}";

Console.WriteLine(fullName);
Console.WriteLine(name);

/// Properties & Methods (non-destructive because strings are immutable)
string email = "   HlatkySzabolcs@gmail.hu   ";
Console.WriteLine($"Length: {email.Length}");
Console.WriteLine($"Contains `@`: {email.Contains("@")}");
Console.WriteLine($"StartsWith `S`: {email.StartsWith("S")}");
Console.WriteLine($"EndsWith `u`: {email.EndsWith("u")}");
Console.WriteLine($"IndexOf `a`: {email.IndexOf("@")}");
Console.WriteLine($"LastIndexOf `a`: {email.LastIndexOf("@")}");
Console.WriteLine($"Substring from 0 to 8: {email.Substring(0, 8)}");
Console.WriteLine($"TrimStart (leading whitespaces): {email.TrimStart()}");
Console.WriteLine($"TrimEnd (trailing whitespaces): {email.TrimEnd()}");
Console.WriteLine($"Trim: {email.Trim()}");
Console.WriteLine($"Replace all `.hu` occurences to `.com`: {email.Replace(".hu", ".com")}");
Console.WriteLine($"Remove 5 characters from the 5th index: {email.Remove(5, 5)}");
Console.WriteLine($"Insert `@` at the 5th index: {email.Insert(5, "@")}");
Console.WriteLine($"PadLeft: {email.PadLeft(30)}");
Console.WriteLine($"PadRight: {email.PadRight(30)}");
Console.WriteLine($"Split by `@`: {string.Join(", ", email.Split('@'))}");
Console.WriteLine($"ToUpperCase: {email.ToUpper()}");
Console.WriteLine($"ToLowerCase: {email.ToLower()}");
Console.WriteLine($"ToCharArray: {string.Join(", ", email.ToCharArray())}");

// NUMBERS

int yearOfBirth = 1993;
int age = 30;
int biggestInteger = int.MaxValue; // 2^31 - 1 = 2147483647
int smallestInteger = int.MinValue; // -2^31 = -2147483648

long biggerInteger = long.MaxValue; // 2^63 - 1 = 9223372036854775807
long smallerInteger = long.MinValue; // -2^63 = -9223372036854775808

// long checkInteger = checked(biggestInteger + biggestInteger); // Overflow

decimal weight = 70.5m; // kg
float height = 172.5f; // cm
double phoneNumber = 06.701234589; // 06 is +36

Console.WriteLine($"Year of birth: {yearOfBirth}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Biggest integer: {biggestInteger}");
Console.WriteLine($"Smallest integer: {smallestInteger}");
Console.WriteLine($"Bigger integer: {biggerInteger}");
Console.WriteLine($"Smaller integer: {smallerInteger}");
// Console.WriteLine($"Checked integer: {checkInteger}");
Console.WriteLine($"Weight: {weight}");
Console.WriteLine($"Height: {height}");
Console.WriteLine($"Phone number: {phoneNumber}");
