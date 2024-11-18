// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;
// Завдання перше
Console.WriteLine("В этом приложении есть возможность вводить некорретные данные. Попробуйте.");
Console.ReadKey();
// Створюємо змінні
string inOperandFirst;
string inOperandSecond;
int isNumber1;
int isNumber2;

Console.WriteLine("Здраствуйте это примитивный калькулятор.\n\nВведите выражение !\n\nПожайста для каждого ввода нажимайте ENTER!");
Found: //мітка з якої точки повторити введення даних


// Введення даних та  Перевірка чи введенні дані є числом  перше число
inOperandFirst = Console.ReadLine();
bool success1 = int.TryParse(inOperandFirst, out isNumber1); 

// Введння оператора разрахунку
string inOperator = Console.ReadLine();
Console.Clear();
Console.WriteLine("{0} {1}", inOperandFirst, inOperator);

// Введення даних та  Перевірка чи введенні дані є числом  друге
inOperandSecond = Console.ReadLine();
Console.Clear();
Console.WriteLine("{0} {1} {2}", inOperandFirst, inOperator, inOperandSecond);
bool success2 = int.TryParse(inOperandSecond, out isNumber2);  


// Обчислення
switch (success1 && success2) 
{
    case true:
        switch (inOperator)
        {
            case "+": Console.WriteLine("Равно  {0}", isNumber1 + isNumber2);
                break;
            case "-": Console.WriteLine("Равно  {0}", isNumber1 - isNumber2);
                 break;
            case "*": Console.WriteLine("Равно  {0}", isNumber1 * isNumber2);
                break;
            case "/": Console.WriteLine("Равно  {0}", Convert.ToDecimal(isNumber1) / Convert.ToDecimal(isNumber2));
                break;

        }
         break;


    case false: //якщо данні не є числом повертаємось на мітку  старту

        Console.Clear();
        Console.WriteLine("Это символы или недопустимый набор знаков введите цифры и оператор!\n\nПопробуйте еще раз . . .\n");
        goto Found;
}
// Завдання друге
Found1: // мітка порверння
Console.WriteLine("Для продолжения нажмите ENTER!");

Console.ReadKey();
Console.Clear();
Console.WriteLine("Это счетик дней недели!\n\nПожалуйста введите номер от 1 до 7 !");

string isNumberDay = Console.ReadLine();
// Перевірка чи введені дані є числом
bool isDay = int.TryParse(isNumberDay, out int isDayWeek);
// Перевірка чи введенечисло є в межах 7 днів
if (isDayWeek > 7)
{
    Console.WriteLine("В неделе только 7 дней. Пожалуйста введите номер от 1 до 7 ! ");

    goto Found1; // якщо більше семи повертаємось на момент ввдення
}
// Виводемо назву дня в залежності від номеру
switch (isDay)
{
    case true:switch(isDayWeek)
        {
            case 1: Console.WriteLine("Monday");
                break;
            case 2: Console.WriteLine("Thusday");
                break;
            case 3: Console.WriteLine("Wensday");
                break;
            case 4: Console.WriteLine("Thursday");
                break;
            case 5: Console.WriteLine("Friday");
                break;
            case 6: Console.WriteLine("Saturday");
                break;  
            case 7: Console.WriteLine("Sunday");
                break;
        };
        break;
        // якщо введені дані не є чмслом вертаємось до міткм введення даних
    case false: Console.WriteLine("Это не номер а символы.\n\nПожалуйста введите номер от 1 до 7 !");
        goto Found1;
        //break;
       
}