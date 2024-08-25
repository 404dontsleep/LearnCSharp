namespace BaiTapTuan1;
class Bai2
{
    public static void Main()
    {
        Console.WriteLine("ax^2 + bx + c = ");
        double a, b, c;
        Console.Write("a b c = ");
        try
        {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) throw new Exception("");
            var ss = s.Split(' ');
            a = double.Parse(ss[0]);
            b = double.Parse(ss[1]);
            c = double.Parse(ss[2]);

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Vo so nghiem");
                    }
                    else
                    {
                        Console.WriteLine("Vo nghiem");
                    }
                }
                else
                {
                    Console.WriteLine("x = {0}", -c / b);
                }
            }
            else
            {
                var delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    Console.WriteLine("Vo nghiem");
                }
                else if (delta == 0)
                {
                    Console.WriteLine("x1 = x2 = {0}", -b / (2 * a));
                }
                else
                {
                    Console.WriteLine("x1 = {0}", (-b + Math.Sqrt(delta)) / (2 * a));
                    Console.WriteLine("x2 = {0}", (-b - Math.Sqrt(delta)) / (2 * a));
                }
            }
        }
        catch
        {
            Console.WriteLine("Khong hop le");
        }
    }
}