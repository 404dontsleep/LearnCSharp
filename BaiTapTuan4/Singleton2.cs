namespace BaiTapTuan4;
public class Singleton2
{
    public static void Main()
    {
        BanPhimAo banPhimAo = BanPhimAo.Instance;
        banPhimAo.Nhap("Hello World");
        BanPhimAo banPhimAo2 = BanPhimAo.Instance;
        banPhimAo2.Nhap("Hello World 2");
        Console.WriteLine(banPhimAo == banPhimAo2);
    }
}

class BanPhimAo
{
    private static BanPhimAo? instance;
    private BanPhimAo()
    {
        Console.WriteLine("Mo ban phim ao");
    }
    public static BanPhimAo Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new BanPhimAo();
            }
            return instance;
        }
    }

    public void Nhap(string message)
    {
        Console.WriteLine(message);
    }
}