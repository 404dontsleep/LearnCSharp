namespace BaiTapTuan1;
class Bai5
{
    public static void Main()
    {
        int n = -1;
        do
        {
            Console.Write("nhap n: ");
            n = int.Parse(Console.ReadLine() ?? "-1");
        } while (n <= 0);
        if (n % 4 == 0 && n % 100 != 0 || n % 400 == 0)
        {
            Console.WriteLine("la nam nhuan");
        }
        else
        {
            Console.WriteLine("khong la nam nhuan");
        }
    }
}