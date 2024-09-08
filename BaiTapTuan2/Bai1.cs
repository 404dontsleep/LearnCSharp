namespace BaiTapTuan2;
class Bai1
{
    public static void Main()
    {
        int n = BaiTapTuan1.Bai7.ReadN();
        Dice dice = new(n);
        Console.WriteLine(dice.Roll());
    }
}

class Dice(int sides)
{
    private static readonly Random random = new();
    private readonly int sides = sides;

    public int Roll()
    {
        return random.Next(1, sides + 1);
    }
}