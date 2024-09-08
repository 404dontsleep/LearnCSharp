namespace BaiTapTuan2;

public static class Bai3
{
    public static void Main()
    {
        List<Song> list = [];
        int n = Helper.Helper.ReadNumber("");
        for (int i = 0; i < n; i++)
        {
            string song = Helper.Helper.ReadString("");
            string[] arg = song.Split("_");
            list.Add(new Song(arg[0], arg[1], arg[2]));
        }
        string typeList = Helper.Helper.ReadString("");
        Console.WriteLine("\n\n");
        list.ForEach(s =>
        {
            if (typeList == "all" || s.TypeList == typeList)
            {
                Console.WriteLine(s.Name);
            }
        });
    }
}

class Song(string typeList, string name, string time)
{
    private string typeList = typeList;
    private string name = name;
    private string time = time;
    public string TypeList { get => typeList; set => typeList = value; }
    public string Name { get => name; set => name = value; }
    public string Time { get => time; set => time = value; }
}