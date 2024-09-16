namespace BaiTapTuan4;
public class Singleton
{
    public static void Main()
    {
        Database database = Database.GetInstance();
        database.Log("Hello World");
        Database database2 = Database.GetInstance();
        database2.Log("Hello World 2");

        Console.WriteLine(database == database2);
    }
}

class Database
{
    private static Database? instance;

    private Database()
    {
        Console.WriteLine("Database created");
    }

    public static Database GetInstance()
    {
        instance ??= new Database();
        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}