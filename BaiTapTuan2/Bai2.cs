namespace BaiTapTuan2;

public static class Bai2
{
    public static void Main()
    {
        Student student = new();
        student.Input();
        student.DisplayStudent();
    }
}

class Person
{
    private int age;
    private string name;
    public int Age { get => age; set => age = value; }
    public string Name { get => name; set => name = value; }

    public void DisplayPerson()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
    public void Input()
    {
        name = Helper.Helper.ReadString("Name: ");
        age = Helper.Helper.ReadNumber("Age: ");
    }
    public Person()
    {
        age = 0;
        name = "";
    }
    public Person(int age, string name)
    {
        this.age = age;
        this.name = name;
    }
    public override string ToString()
    {
        return $"Name: {name}, Age: {age}";
    }
}

class Student : Person
{
    private float gpa;
    public float Gpa { get => gpa; set => gpa = value; }
    public void DisplayStudent()
    {
        base.DisplayPerson();
        Console.WriteLine("GPA: " + gpa);
    }
    public new void Input()
    {
        base.Input();
        gpa = Helper.Helper.ReadFloat("GPA: ");
    }
    public Student() : base()
    {
        gpa = 0.0f;
    }
    public Student(int age, string name, float gpa) : base(age, name)
    {
        this.gpa = gpa;
    }
}