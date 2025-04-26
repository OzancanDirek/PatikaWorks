class Reverse
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir string ifade girin:");
        string input = Console.ReadLine();

        string[] kelimeler = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

        for (int i = 0; i < kelimeler.Length; i++)
        {
            string kelime = kelimeler[i];

            if (kelime.Length > 1)
            {
                char ilkHarf = kelime[0];
                char sonHarf = kelime[kelime.Length - 1];
                string ortaKisim = kelime.Substring(1, kelime.Length - 2);

                kelimeler[i] = $"{sonHarf}{ortaKisim}{ilkHarf}";
            }
        }

        if (kelimeler.Length >= 2)
        {
            string temp = kelimeler[0];
            kelimeler[0] = kelimeler[kelimeler.Length - 1];
            kelimeler[kelimeler.Length - 1] = temp;
        }

        string sonuc = string.Join(' ', kelimeler);
        Console.WriteLine(sonuc);
    }
}