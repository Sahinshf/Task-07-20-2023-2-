using System.Security.Cryptography.X509Certificates;

namespace Task2;

 class Program
{
    static void Main(string[] args)
    {
        
        int sqrResult = Power(int.Parse(Console.ReadLine()));
        int pwrResult = Power(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
        Console.WriteLine(sqrResult+ pwrResult);

    }
    static int Power(int num)
    {
        return num * num; 
    }

    static int Power(int num1, int num2)
    {
        return (int)Math.Pow(num1, num2); 
    }
}
