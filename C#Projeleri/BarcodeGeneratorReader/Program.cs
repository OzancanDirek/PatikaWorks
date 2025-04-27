using System;
using System.Drawing;
using System.IO;
using ZXing;
using ZXing.Windows.Compatibility;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Veri girin:");
        string data = Console.ReadLine();

        BarcodeWriter writer = new BarcodeWriter();
        writer.Format = BarcodeFormat.QR_CODE;
        writer.Options = new ZXing.Common.EncodingOptions
        {
            Width = 400,
            Height = 400,
            Margin = 0
        };

        var result = writer.Write(data);

        string path = "barcode.png";
        if (File.Exists(path))
            File.Delete(path);

        result.Save(path, System.Drawing.Imaging.ImageFormat.Png);
        Console.WriteLine($"Barcode kaydedildi: {path}");

        var reader = new BarcodeReader();
        var barcodeBitmap = new Bitmap(path);
        var decodeResult = reader.Decode(barcodeBitmap);

        if (decodeResult != null)
        {
            Console.WriteLine($"Okunan Barkod Verisi: {decodeResult.Text}");
        }
        else
        {
            Console.WriteLine("Barkod okunamadı.");
        }
    }
}
