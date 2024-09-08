namespace Helper;

public static class Helper
{
    public static int ReadNumber(string message)
    {
        int n = -1;
        do
        {
            Console.Write(message);
            n = int.Parse(Console.ReadLine() ?? "-1");
        } while (n <= 0);
        return n;
    }
    public static string ReadString(string message)
    {
        Console.Write(message);
        return Console.ReadLine() ?? "";
    }
    public static float ReadFloat(string message)
    {
        float n = -1;
        do
        {
            Console.Write(message);
            n = float.Parse(Console.ReadLine() ?? "-1");
        } while (n <= 0);
        return n;
    }
}