namespace BaiTapTuan1;
class Bai3
{
    public static void Main()
    {
        int n = -1;
        do
        {
            Console.WriteLine("nhap n: ");
            try
            {
                n = int.Parse(Console.ReadLine() ?? "-1");
            }
            catch { }
        } while (n < 0);
        Console.WriteLine("n = {0}", n);
    }
}