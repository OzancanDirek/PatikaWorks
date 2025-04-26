class Program
{
    static string[] kategoriler = { "Spor", "Aksiyon", "Korku" };
    static int[] ilkOylar = { 0, 0, 0 };
    static List<string> kayıtlıKullanıcıAdları = new List<string> { "Ozan", "Mehmet", "Emre" };

    static void Kayıt()
    {
        Console.WriteLine("Kullanıcı adınızı giriniz:");
        string kullanıcıAd = Console.ReadLine();

        bool kullanıcıBulundu = false;

        for (int i = 0; i < kayıtlıKullanıcıAdları.Count; i++)
        {
            if (kullanıcıAd == kayıtlıKullanıcıAdları[i])
            {
                Console.WriteLine("Voting Uygulamasına Hoşgeldiniz!");
                kullanıcıBulundu = true;
                break;
            }
        }

        if (!kullanıcıBulundu)
        {
            Console.WriteLine("Kullanıcı adı bulunamadı, sisteme kayıt oluyorsunuz...");
            kayıtlıKullanıcıAdları.Add(kullanıcıAd);
        }
    }

    static void OyVerme()
    {
        Console.WriteLine("**************************************************");
        Console.WriteLine("Oyunuzu veriniz:");
        for (int i = 0; i < kategoriler.Length; i++)
        {
            Console.WriteLine($"{kategoriler[i]}: {i + 1}");
        }

        int secim = Convert.ToInt32(Console.ReadLine());

        switch (secim)
        {
            case 1:
                ilkOylar[0]++;
                break;
            case 2:
                ilkOylar[1]++;
                break;
            case 3:
                ilkOylar[2]++;
                break;
            default:
                Console.WriteLine("Hatalı giriş");
                break;
        }

        Console.WriteLine("**************************************************");
        Console.WriteLine("Güncel Oylar:");
        for (int i = 0; i < kategoriler.Length; i++)
        {
            Console.WriteLine($"{kategoriler[i]}: {ilkOylar[i]} oy");
        }
    }

    static void Main()
    {
        Kayıt();
        OyVerme();
    }
}