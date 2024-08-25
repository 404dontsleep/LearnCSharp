namespace BaiTapTuan1;
class Bai6
{
    public static void Main()
    {
        int n = -1;
        do
        {
            Console.Write("nhap n: ");
            n = int.Parse(Console.ReadLine() ?? "-1");
        } while (n <= 0);
        double s = 0.0;
        for (int i = 1; i <= n; i++)
        {
            s += 1.0 / i;
        }
        Console.WriteLine("s = {0}", s);
    }
}