namespace BaiTapTuan3;
public class Manager<T> where T : IManager
{
    public List<T> list = [];
    public void Input()
    {

    }

    public void Display()
    {

    }
}

public interface IManager
{
    void Input();
    void Display();
}