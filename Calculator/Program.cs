// See https://aka.ms/new-console-template for more information
using System.IO.Pipelines;

Console.WriteLine("Welcome to the calculator!");
Console.WriteLine("==========================");
Console.Write("Please enter the operator :");
string oper = Console.ReadLine();

Console.Write("How many numbers do you want to " + oper + " :");
int noOfNo = int.Parse(Console.ReadLine());

int[] noArray = new int[noOfNo];

for (int i = 0; i < noOfNo; i++)
{
    Console.Write("Please enter number "+(i+1)+" :");
    noArray[i]= int.Parse(Console.ReadLine());
}

float result = noArray[0];

if (oper == "+")
{
    for (int i = 1; i < noOfNo; i++)
    {
        result += noArray[i];
    }

}
else if (oper == "-")
{
    for (int i = 1; i < noOfNo; i++)
    {
        result -= noArray[i];
    }
}
else if (oper == "*")
{
    for (int i = 1; i < noOfNo; i++)
    {
        result *= noArray[i];
    }
}
else if (oper == "/")
{
    for (int i = 1; i < noOfNo; i++)
    {
        result /= noArray[i];
    }
}

Console.WriteLine("The answer is " + result.ToString());
Console.ReadLine();