class mutlakDeger
{
    static void Main()
    {
        Console.WriteLine("Istediğiniz sayıları giriniz...");
        string input = Console.ReadLine();

        string[] number = input.Split(",");
        int[] realNumbers = Array.ConvertAll(number, int.Parse);

        int kucukToplam = 0;
        int buyukToplam = 0;

        foreach (int i in realNumbers)
        {
            if (i < 67)
            {
                kucukToplam += (67 - i);
            }
            else if (i > 67)
            {
                int fark = i - 67;
                buyukToplam += fark * fark;
            }
        }
        Console.WriteLine($" 67'den kucuk sayıların farkları toplamı: {kucukToplam}" +
            $"\n Buyuk olanların Mutlak kareleri toplamı: {buyukToplam}");

    }
}