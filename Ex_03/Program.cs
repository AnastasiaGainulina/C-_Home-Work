// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число ");

        int n = int.Parse(Console.ReadLine());

        if (n % 2 == 1) 
        {
            Console.WriteLine("Число нечетное ");
        }
else
        {
            Console.WriteLine("Число четное ");
        }
    }
}