// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;


string inOperandFirst;
string inOperandSecond;
int isNumber1;
int isNumber2;

Console.WriteLine("Введите выражение !\n\nПожайста для каждого ввода нажимайте ENTER!");
Found:

inOperandFirst = Console.ReadLine();
bool success1 = int.TryParse(inOperandFirst, out isNumber1);

string inOperator = Console.ReadLine();
Console.Clear();
Console.WriteLine("{0} {1}", inOperandFirst, inOperator);

inOperandSecond = Console.ReadLine();
Console.Clear();
Console.WriteLine("{0} {1} {2}", inOperandFirst, inOperator, inOperandSecond);

bool success2 = int.TryParse(inOperandSecond, out isNumber2);



switch (success1 && success2)
{
    case true:
        switch (inOperator)
        {
            case "+":
                Console.WriteLine("Равно  {0}", isNumber1 + isNumber2);
                break;
            case "-":
                Console.WriteLine("Равно  {0}", isNumber1 - isNumber2);
                break;
            case "*":
                Console.WriteLine("Равно  {0}", isNumber1 * isNumber2);
                break;
            case "/":
                Console.WriteLine("Равно  {0}", Convert.ToDecimal(isNumber1) / Convert.ToDecimal(isNumber2));
                break;
            
        }
        break;
 

    case false:

        Console.Clear();
        Console.WriteLine("Это символы или недопустимый набор знаков введите цифры и оператор!\n\nПопробуйте еще раз . . .\n");
        goto Found;
}
