// See https://aka.ms/new-console-template for more information

using RomanNumeralsNamespace.Models;

Console.WriteLine("Please insert your roman numeral in all caps: ");
string ? userNumber = Console.ReadLine();
if (userNumber == null) userNumber = "";
Console.WriteLine("The value of that number is: " + RomanNumerals.NumeralToInt(userNumber));

/*Console.WriteLine(RomanNumerals.NumeralToInt("I"));
Console.WriteLine(RomanNumerals.NumeralToInt("II"));
Console.WriteLine(RomanNumerals.NumeralToInt("III"));
Console.WriteLine(RomanNumerals.NumeralToInt("IV"));
Console.WriteLine(RomanNumerals.NumeralToInt("V"));
Console.WriteLine(RomanNumerals.NumeralToInt("VI"));
Console.WriteLine(RomanNumerals.NumeralToInt("VII"));
Console.WriteLine(RomanNumerals.NumeralToInt("VIII"));
Console.WriteLine(RomanNumerals.NumeralToInt("IX"));
Console.WriteLine(RomanNumerals.NumeralToInt("X"));
Console.WriteLine(RomanNumerals.NumeralToInt("XI"));
Console.WriteLine(RomanNumerals.NumeralToInt("XII"));
Console.WriteLine(RomanNumerals.NumeralToInt("XIII"));
Console.WriteLine(RomanNumerals.NumeralToInt("XIV"));
Console.WriteLine(RomanNumerals.NumeralToInt("XV"));
Console.WriteLine(RomanNumerals.NumeralToInt("XVI"));
Console.WriteLine(RomanNumerals.NumeralToInt("XVII"));
Console.WriteLine(RomanNumerals.NumeralToInt("XVIII"));
Console.WriteLine(RomanNumerals.NumeralToInt("XIX"));
Console.WriteLine(RomanNumerals.NumeralToInt("XX"));
Console.WriteLine(RomanNumerals.NumeralToInt("XXI"));
Console.WriteLine(RomanNumerals.NumeralToInt("XXII"));
Console.WriteLine(RomanNumerals.NumeralToInt("XXIII"));
Console.WriteLine(RomanNumerals.NumeralToInt("XXIV"));
Console.WriteLine(RomanNumerals.NumeralToInt("XXV"));
Console.WriteLine(RomanNumerals.NumeralToInt("XXVI"));
Console.WriteLine(RomanNumerals.NumeralToInt("XXVII"));
Console.WriteLine(RomanNumerals.NumeralToInt("XXVIII"));
Console.WriteLine(RomanNumerals.NumeralToInt("XXIX"));
Console.WriteLine(RomanNumerals.NumeralToInt("XXX"));*/