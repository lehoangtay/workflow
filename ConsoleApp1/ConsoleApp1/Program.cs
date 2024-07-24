using System;
public interface ICalculatorService
{
    int Add(int a, int b);
    int Subtract(int a, int b);
}
public class CalculatorService: ICalculatorService
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Subtract(int a, int b)
    {
        return a - b;
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        ICalculatorService calculator = new CalculatorService();
        int resu1t = calculator.Add(5, 3);
        Console.WriteLine("ket qu cua phep conng: " + resu1t);
        resu1t = calculator.Subtract(5, 3);
        Console.WriteLine("ket quua cua phep tru: " + resu1t);
    }
}

