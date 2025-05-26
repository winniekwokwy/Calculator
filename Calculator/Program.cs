// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to the calculator!");
Console.Write("Please tell me a number :");
int firstNo = int.Parse(Console.ReadLine());

Console.Write("Please tell me another number :");
int secondNo = int.Parse(Console.ReadLine());

Console.WriteLine("The result of multiplying the two numbers is " + (firstNo * secondNo).ToString());
Console.ReadLine();