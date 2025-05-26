// See https://aka.ms/new-console-template for more information
using System.IO.Pipelines;

Console.WriteLine("Welcome to the calculator!");
Console.WriteLine("==========================");
Console.Write("Please enter the operator :");
string oper = Console.ReadLine();

Console.Write("Please enter the first number :");
int firstNo = int.Parse(Console.ReadLine());

Console.Write("Please enter the second number :");
int secondNo = int.Parse(Console.ReadLine());

float result = 0;

if (oper == "+")
    result = firstNo + secondNo;
else if (oper == "-")
    result = firstNo - secondNo;
else if (oper == "*")
    result = firstNo * secondNo;
else if (oper == "/")
    result = firstNo / secondNo;

Console.WriteLine("The answer is " + result.ToString());
Console.ReadLine();