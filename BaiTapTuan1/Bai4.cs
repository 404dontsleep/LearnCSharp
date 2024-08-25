namespace BaiTapTuan1;
class Bai4
{
    public static void Main()
    {
        int n;
        do
        {
            Console.Write("nhap n: ");
            try
            {
                n = int.Parse(Console.ReadLine() ?? "0.1");
                break;
            }
            catch { }
        }
        while (true);
        if (IsPrime(n))
        {
            Console.WriteLine("la so nguyen to");
        }
        else
        {
            Console.WriteLine("khong la so nguyen to");
        }
    }
    public static bool IsPrime(int n)
    {
        if (n < 2) return false;
        bool prime = true;
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                prime = false;
                break;
            }
        }
        return prime;
    }
}