// See https://aka.ms/new-console-template for more information
int test = 1234;

var digits = test.ToString().Select(x => int.Parse(x.ToString())); ;

Console.WriteLine(digits.Last());