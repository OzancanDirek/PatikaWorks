Console.WriteLine("Enter word and number (e.g. merhaba,3):");
string input = Console.ReadLine();

string[] parts = input.Split(",");


string word = parts[0];
int number = int.Parse(parts[1]);

string dif = word.Substring(0, number);
Console.WriteLine(dif);