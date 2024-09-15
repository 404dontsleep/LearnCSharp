namespace BaiTapTuan3;
public class Bai1
{
    public static void Main()
    {
        Line line = new(50, 4, 54, 5);
        line.Show();
        line.Move(10, 10);
        line.Show();
        Circle circle = new(50, 4, 10);
        circle.Show();
        circle.Move(10, 10);
        circle.Show();
        Rectangle rectangle = new(50, 4, 10, 20);
        rectangle.Show();
        rectangle.Move(10, 10);
        rectangle.Show();
        PolyLine polyline = new(50, 4);
        polyline.Show();
        polyline.Move(10, 10);
        polyline.Show();
    }
}

class Shape(int x, int y)
{
    protected int x = x, y = y;
    public virtual void Move(int dx, int dy)
    {
        x += dx;
        y += dy;
    }
    public virtual void Show()
    {
        Console.WriteLine("x = {0}, y = {1}", x, y);
    }
}

class Line(int x1, int y1, int x2, int y2) : Shape(x1, y1)
{
    private int x1 = x1, y1 = y1, x2 = x2, y2 = y2;
    override public void Show()
    {
        Console.WriteLine("x1 = {0}, y1 = {1}, x2 = {2}, y2 = {3}", x1, y1, x2, y2);
    }
    override public void Move(int dx, int dy)
    {
        x1 += dx;
        y1 += dy;
        x2 += dx;
        y2 += dy;
    }
}

class Circle(int x, int y, int r) : Shape(x, y)
{
    private readonly int r = r;
    override public void Show()
    {
        Console.WriteLine("x = {0}, y = {1}, r = {2}", x, y, r);
    }
    override public void Move(int dx, int dy)
    {
        x += dx;
        y += dy;
    }
}

class Rectangle(int x, int y, int w, int h) : Shape(x, y)
{
    private readonly int w = w, h = h;
    override public void Show()
    {
        Console.WriteLine("x = {0}, y = {1}, w = {2}, h = {3}", x, y, w, h);
    }
    override public void Move(int dx, int dy)
    {
        x += dx;
        y += dy;
    }
}

class PolyLine(int x, int y) : Shape(x, y)
{
    public override void Move(int dx, int dy)
    {
        x += dx;
        y += dy;
    }
    public override void Show()
    {
        Console.WriteLine("x = {0}, y = {1}", x, y);
    }
}