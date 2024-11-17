// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;


string inOperandFirst;
string inOperandSecond;
int isNumber1;
int isNumber2;
Found:
Console.WriteLine("Enter number#1");

inOperandFirst =Console.ReadLine();
bool success1 = int.TryParse(inOperandFirst, out isNumber1);

Console.WriteLine("Enter number#2");

inOperandSecond = Console.ReadLine();
bool success2 = int.TryParse(inOperandSecond, out isNumber2);


if (success1 && success2) 
{
    Console.WriteLine("Числа {0}, {1}" ,isNumber1 , isNumber2);
}
else
{
    Console.Clear();
    Console.WriteLine("Это символы введите цифры\nПопробуйте еще раз");
    goto Found;
}
