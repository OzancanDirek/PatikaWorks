public abstract class GeometrikSekil
{
    public abstract void KullanıcıBilgi();
    public abstract double alanHesapla();
    public abstract double cevreHesapla();

}

public class Daire: GeometrikSekil
{
    private double _yarıcap;

    public override void KullanıcıBilgi()
    {
        Console.WriteLine("Yarıcapı giriniz");
        _yarıcap = Convert.ToDouble(Console.ReadLine());
    }
    public override double alanHesapla()
    {
        return Math.PI * Math.Pow(_yarıcap , 2);
    }

    public override double cevreHesapla()
    {
        return 2 * Math.PI *  _yarıcap;
    }
}

public class Ucgen: GeometrikSekil
{
    private double _taban,_yukseklik,_kenar1,_kenar2,_kenar3;

    public override void KullanıcıBilgi()
    {
        Console.WriteLine("Ucgenin Taban Uzunluğunu Giriniz");
        _taban = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ucgenin Yuksekliğini Giriniz");
        _yukseklik = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ucgenin uc kenar uzunluğunu giriniz (kenar1, kenar2, kenar3)");
        _kenar1 = Convert.ToDouble(Console.ReadLine());
        _kenar2 = Convert.ToDouble(Console.ReadLine());
        _kenar3 = Convert.ToDouble(Console.ReadLine());
    }

    public override double alanHesapla()
    {
        return (_taban * _yukseklik) / 2;
    }
    public override double cevreHesapla()
    {
        return _kenar1 + _kenar2 + _kenar3;
    }
}

public class Kare: GeometrikSekil
{
    private double _kenar;

    public override void KullanıcıBilgi()
    {
        Console.WriteLine("Karenin bir kenarını giriniz");
        _kenar = Convert.ToDouble(Console.ReadLine());

    }

    public override double alanHesapla()
    {
        return Math.Pow(_kenar,2);
    }
    public override double cevreHesapla()
    {
        return 4 * _kenar;
    }
}

public class Dikdortgen: GeometrikSekil
{
    private double _uzunluk, _genislik;

    public override void KullanıcıBilgi()
    {
        Console.WriteLine("Dikdortgenin Uzunluğunu giriniz");
        _uzunluk = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Dikdortgenin genisliğini giriniz");
        _genislik = Convert.ToDouble(Console.ReadLine());

    }
    public override double alanHesapla()
    {
        return _uzunluk * _genislik;
    }
    public override double cevreHesapla()
    {
        return 2 * (_uzunluk + _genislik);
    }

}

public class SekilHesapla()
{
    public void Hesaplama(GeometrikSekil sekil)
    {
        Console.WriteLine("Hesaplamak istediğin değeri sec \nAlan:1 \nCevre: 2");
        int input = Convert.ToInt32(Console.ReadLine());

        switch (input)
        {
            case 1:
                Console.WriteLine("Alan: " + sekil.alanHesapla());
                break;
            case 2:
                Console.WriteLine("Cevre " + sekil.cevreHesapla());
                break;
            default:
                Console.WriteLine("Hatalı Giris Yaptınız");
                break;
        }
    }
}

class program
{
    static void Main()
    {
        Console.WriteLine("Hesaplamak istediğiniz Sekli seciniz" +
            "\n Daire: 1" +
            "\n Ucgen: 2" +
            "\n Kare: 3" +
            "\n Dikdortgen: 4");
        int input = Convert.ToInt32(Console.ReadLine());

        GeometrikSekil sekil = null;

        switch (input)
        {
            case 1:
                sekil = new Daire();
                break;
            case 2:
                sekil = new Ucgen();
                break;
            case 3:
                sekil = new Kare();
                break;
            case 4:
                sekil = new Dikdortgen();
                break;
            default:
                Console.WriteLine("Geçersiz seçim.");
                return;
        }
        sekil.KullanıcıBilgi();

        SekilHesapla hesap = new SekilHesapla();
        hesap.Hesaplama(sekil); 
        
    }
}
