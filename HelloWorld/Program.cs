// See https://aka.ms/new-console-template for more information
using PasswordGenerator;

Console.WriteLine("Hello, World!");

var name = Console.ReadLine();
var currentDate = DateTime.Now;
Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
Console.ReadKey(true);

// https://www.nuget.org/packages/PasswordGenerator
// By default, all characters available for use and a length of 16
// Will return a random password with the default settings
var pwd = new Password();
var password = pwd.Next();
Console.Write(password.ToString());
