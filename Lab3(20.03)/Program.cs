using Lab3_20._03_;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        Number number1 = new Number(9.2, 78.25);

        number1.SaveToJson("number.json");

        Number number2 = Number.LoadFromJson("number.json");

        Console.WriteLine("The sum of two variables: " + number2.Sum());
        Console.WriteLine("Difference of two variables: " + number2.Difference());
        Console.WriteLine("The product of two variables: " + number2.Product());
        Console.WriteLine("Division of two variables: " + number2.Division());
        Console.WriteLine("Remainder of dividing two variables: " + number2.Remainder());

        Console.WriteLine();

        Console.WriteLine("Comparing the sum of two pairs of variables: " + number1.Compare(number2));


        Console.ReadKey();
    }
}
