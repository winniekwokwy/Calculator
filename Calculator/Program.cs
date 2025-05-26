// See https://aka.ms/new-console-template for more information
using System.IO.Pipelines;
using System.Runtime.CompilerServices;

int getUserInput(string message)
{
    int result = 0;
    do
    {
        Console.Write(message);
        string input = Console.ReadLine();

        if (int.TryParse(input, out result))
        {
            return result;
        }
    } while (true);
}

int add(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result += numbers[i];
    }
    return result;
}

int minus(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result -= numbers[i];
    }
    return result;
}

int multiply(int[] numbers)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result *= numbers[i];
    }
    return result;
}

float divide(int[] numbers)
{
    float result = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        result /= numbers[i];
    }
    return result;
}
Console.WriteLine("Welcome to the calculator!");
Console.WriteLine("==========================");

Console.Write("Please enter the operator :");
string oper = Console.ReadLine();


int noOfNo = getUserInput("How many numbers do you want to " + oper + " :");

int[] noArray = new int[noOfNo];

for (int i = 0; i < noOfNo; i++)
{
    noArray[i]= getUserInput("Please enter number "+(i+1)+" :");
}

float result = 0;

if (oper == "+")
{
    result = add(noArray);
}
else if (oper == "-")
{
    result = minus(noArray);
}
else if (oper == "*")
{
    result = multiply(noArray);
}
else if (oper == "/")
{
    result = divide(noArray);
}

Console.WriteLine("The answer is " + result.ToString());
Console.ReadLine();