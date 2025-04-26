using System.Linq;

Console.WriteLine("Kontrol etmek istediğiniz kelimeyi lütfen yazınız");
string input = Console.ReadLine();

bool varmı = false;

char[] sessizHarfler = { 'z', 'y', 'v', 't', 'ş', 's', 'r', 'p', 'n', 'm', 'l', 'k', 'h', 'j', 'ğ', 'g', 'd', 'ç', 'c', 'b' };

for (int i = 0; i < input.Length - 1; i++)
{
    char ifade = input[i];
    char ifadeyan = input[i + 1];

    if (sessizHarfler.Contains(ifade) && sessizHarfler.Contains(ifadeyan))
    {
        varmı = true;
        break;
    }
}

if (varmı)
{
    Console.WriteLine($"Arka arkaya iki sessiz harf var: {varmı}");
}
else
{
    Console.WriteLine($"Arka arkaya iki sessiz harf yok: {varmı}");
}
