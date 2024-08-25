namespace BaiTapTuan1;
class Bai7
{
    public static void Main()
    {
        Random random = new Random();
        int n = random.Next(1, 100);
        int maxChance = 7;
        while (maxChance-- > 0)
        {
            Console.WriteLine("Ban con {0} co hoi", maxChance + 1);
            int rn = ReadN();
            if (rn == n)
            {
                Console.WriteLine("ban da doan dung");
                break;
            }
            if (rn > n)
            {
                Console.WriteLine("Lon hon");
            }
            if (rn < n)
            {
                Console.WriteLine("Nho hơn");
            }
        }
        if (maxChance == -1)
        {
            Console.WriteLine("ban da thua");
        }
    }
    public static int ReadN()
    {
        int n = -1;
        do
        {
            Console.Write("nhap n: ");
            n = int.Parse(Console.ReadLine() ?? "-1");
        } while (n <= 0);
        return n;
    }
}