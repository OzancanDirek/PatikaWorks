Console.Write("Yarıçapı giriniz: ");
int r = Convert.ToInt32(Console.ReadLine());

for (int y = -r; y <= r; y++)
{
    for (int x = -r; x <= r; x++)
    {
        double mesafe = Math.Sqrt(x * x + y * y);
        if (mesafe > r - 0.5 && mesafe < r + 0.5)
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}