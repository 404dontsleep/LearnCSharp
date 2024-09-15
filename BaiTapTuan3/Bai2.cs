namespace BaiTapTuan3;
public class Bai2
{
    public static void Main()
    {
        Cat cat = new();
        cat.Infomation();
        cat.Sound();
        cat.Climb();
        Duck duck = new();
        duck.Infomation();
        duck.Sound();
        duck.Swim();
        Dog dog = new("Spaniel");
        dog.Infomation();
        dog.Sound();
    }

}

abstract class Animal(string type)
{
    public string type = type;
    public abstract void Sound();
    public abstract void Infomation();
}
class Dog(string breed) : Animal("Mammal")
{
    public override void Infomation()
    {
        Console.WriteLine($"Type: {type}, Breed: {breed}");
    }
    public override void Sound()
    {
        Console.WriteLine("Gau gau");
    }
}

class Cat() : Animal("Mammal")
{
    public override void Infomation()
    {
        Console.WriteLine($"Type: {type}");
    }
    public override void Sound()
    {
        Console.WriteLine("Meo meo");
    }
    public void Climb()
    {
        Console.WriteLine("Climb");
    }
}

class Duck() : Animal("Bird")
{
    public override void Infomation()
    {
        Console.WriteLine($"Type: {type}");
    }
    public override void Sound()
    {
        Console.WriteLine("Ga ga");
    }
    public void Swim()
    {
        Console.WriteLine("Swim");
    }
}