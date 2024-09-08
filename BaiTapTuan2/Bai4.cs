namespace BaiTapTuan2;

public static class Bai4
{
    public static void Main()
    {
        Console.WriteLine("Input first fraction:");
        Fraction fraction1 = Fraction.InputFraction();

        Console.WriteLine("Input second fraction:");
        Fraction fraction2 = Fraction.InputFraction();

        Console.WriteLine("Addition: " + fraction1.Add(fraction2).ToString());
        Console.WriteLine("Subtraction: " + fraction1.Subtract(fraction2).ToString());
        Console.WriteLine("Multiplication: " + fraction1.Multiply(fraction2).ToString());
        Console.WriteLine("Division: " + fraction1.Divide(fraction2).ToString());

        Console.WriteLine("First fraction as decimal: " + fraction1.ToDecimalString());
        Console.WriteLine("Second fraction as decimal: " + fraction2.ToDecimalString());
    }

}

class Fraction
{
    private int numerator;
    private int denominator;

    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this.numerator = numerator;
        this.denominator = denominator;
        Normalize();
    }
    public static Fraction InputFraction()
    {
        int numerator = Helper.Helper.ReadNumber("Enter the numerator: ");
        int denominator = Helper.Helper.ReadNumber("Enter the denominator: ");
        return new Fraction(numerator, denominator);
    }
    private void Normalize()
    {
        int gcd = GCD(numerator, denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public Fraction Add(Fraction other)
    {
        int newNumerator = numerator * other.denominator + other.numerator * denominator;
        int newDenominator = denominator * other.denominator;
        return new Fraction(newNumerator, newDenominator);
    }
    public Fraction Subtract(Fraction other)
    {
        int newNumerator = numerator * other.denominator - other.numerator * denominator;
        int newDenominator = denominator * other.denominator;
        return new Fraction(newNumerator, newDenominator);
    }
    public Fraction Multiply(Fraction other)
    {
        int newNumerator = numerator * other.numerator;
        int newDenominator = denominator * other.denominator;
        return new Fraction(newNumerator, newDenominator);
    }
    public Fraction Divide(Fraction other)
    {
        if (other.numerator == 0)
            throw new DivideByZeroException("Cannot divide by a fraction with zero numerator.");

        int newNumerator = numerator * other.denominator;
        int newDenominator = denominator * other.numerator;
        return new Fraction(newNumerator, newDenominator);
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }

    public string ToDecimalString()
    {
        return ((double)numerator / denominator).ToString("F2");
    }
}
