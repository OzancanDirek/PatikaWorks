Console.WriteLine("Enter your sentences:");
string input = Console.ReadLine();

string[] words = input.Split(" ");

for (int i = 0; i < words.Length; i++)
{
    char[] chars = words[i].ToCharArray(); 
    Array.Reverse(chars);
    Console.WriteLine(chars);
}
Console.ReadLine();