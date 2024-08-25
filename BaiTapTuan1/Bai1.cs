namespace BaiTapTuan1;
class Bai1
{
    public static void Main()
    {
        Console.Write("Ho ten: ");
        var hoten = Console.ReadLine();
        if (!string.IsNullOrEmpty(hoten))
        {
            Console.WriteLine($"{hoten.ToUpper()}");
        }
        else
        {
            Console.WriteLine("Chua nhap ho ten");
        }
        Console.Write("Diem thi: ");
        var diemthi = Console.ReadLine();
        if (!string.IsNullOrEmpty(diemthi))
        {
            try
            {
                double diem = double.Parse(diemthi);
                if (diem < 0.0 || diem > 10.0) throw new Exception("");
                if (diem >= 8)
                {
                    Console.WriteLine("Gioi");
                }
                else if (diem >= 6.5)
                {
                    Console.WriteLine("Kha");
                }
                else if (diem >= 5.0)
                {
                    Console.WriteLine("Trung binh");
                }
                else
                {
                    Console.WriteLine("Yeu");
                }
            }
            catch
            {
                Console.WriteLine("Diem khong hop le");
            }
        }
    }
}