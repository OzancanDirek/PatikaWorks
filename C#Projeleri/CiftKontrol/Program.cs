class Program
{
    static void Main()
    {
        Console.WriteLine("Sayıları giriniz (örnek: 2 3 1 5 3 3):");
        string input = Console.ReadLine();

        string[] list = input.Split(' '); // bosluk bırakarak sayıları liste kayıt ediyorum

        for (int i = 0; i < list.Length; i += 2)
        {
            int sayı1 = int.Parse(list[i]); 
            int sayı2 = int.Parse(list[i + 1]); //ikinci sayıyı aldım

            int toplam = sayı1 + sayı2;

            if (sayı1 == sayı2)
            {
                Console.Write((toplam * toplam) + " "); //karesini almak için
            }
            else
            {
                Console.Write(toplam + " "); 
            }
        }

        Console.WriteLine(); // Alt satıra geçmek için
    }
}