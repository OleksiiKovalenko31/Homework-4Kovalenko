// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;
Console.OutputEncoding = System.Text.Encoding.UTF8;
// Завдання перше
//Console.WriteLine("В этом приложении есть возможность вводить некорретные данные. Попробуйте.");
//Console.ReadKey();
// Створюємо змінні
//string inOperandFirst;
//string inOperandSecond;
//int isNumber1;
//int isNumber2;
//Console.WriteLine("Здраствуйте это примитивный калькулятор.\n\nВведите выражение !\n\nПожайста для каждого ввода нажимайте ENTER!");



// Введення даних та  Перевірка чи введенні дані є числом  перше число
//string inOperandFirst = Console.ReadLine();
//bool success1 = int.TryParse(inOperandFirst, out int isNumber1);

// Введння оператора разрахунку
//string inOperator = Console.ReadLine();
//Console.WriteLine("{0} {1}", inOperandFirst, inOperator);

// Введення даних та  Перевірка чи введенні дані є числом  друге
//string inOperandSecond = Console.ReadLine();
//Console.Clear();
//Console.WriteLine("{0} {1} {2}", inOperandFirst, inOperator, inOperandSecond);
//bool success2 = int.TryParse(inOperandSecond, out int isNumber2);


// Обчислення
//switch (success1 && success2)
//{
//case true:



try
{
    int isNumber1;
    int isNumber2;
    string inOperator;

    Console.WriteLine("Введіть перше число: "); isNumber1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Введіть оператор: "); inOperator = Console.ReadLine();
    Console.WriteLine("Введіть друге число: ");  isNumber2 = int.Parse(Console.ReadLine());
    

    switch (inOperator)
    {
        case "+":
            Console.WriteLine("Дорівнює  {0}", isNumber1 + isNumber2);
            break;
        case "-":
            Console.WriteLine("Дорівнює  {0}", isNumber1 - isNumber2);
            break;
        case "*":
            Console.WriteLine("Дорівнює  {0}", isNumber1 * isNumber2);
            break;
        case "/":
            Console.WriteLine("Дорівнює  {0}", Convert.ToDecimal(isNumber1) / Convert.ToDecimal(isNumber2));
            break;

    }

}
catch (DivideByZeroException)
{
    Console.WriteLine("На 0 ділити не можна! ");
}
catch (OverflowException)
{
    Console.WriteLine("Задовге чи закоротке число !");
}
catch (FormatException)
{
    Console.WriteLine("Введеі дані не є вірними! ");
}
catch (Exception ms) 
{   
    Console.WriteLine("Непердбачувана помилка! " );
}

//finally
//{ }

//case false: //якщо данні не є числом повертаємось на мітку  старту

//{
//Console.Clear();
//        Console.WriteLine("Это символы или недопустимый набор знаков введите цифры и оператор!\n\nПопробуйте еще раз . . .\n");
    //}
    //    break;
//}

//// Завдання друге
//Console.WriteLine("Для продолжения нажмите ENTER!");

//Console.ReadKey();
//Console.Clear();
//Console.WriteLine("Это счетик дней недели!\n\nПожалуйста введите номер от 1 до 7 !");

//string isNumberDay = Console.ReadLine();
//// Перевірка чи введені дані є числом
//bool isDay = int.TryParse(isNumberDay, out int isDayWeek);
//// Перевірка чи введенечисло є в межах 7 днів
//if (isDayWeek > 7)
//{
//    Console.WriteLine("В неделе только 7 дней. Пожалуйста введите номер от 1 до 7 ! ");
//}
//// Виводемо назву дня в залежності від номеру
//switch (isDay)
//{
//    case true:switch(isDayWeek)
//        {
//            case 1: Console.WriteLine("Monday");
//                break;
//            case 2: Console.WriteLine("Thusday");
//                break;
//            case 3: Console.WriteLine("Wensday");
//                break;
//            case 4: Console.WriteLine("Thursday");
//                break;
//            case 5: Console.WriteLine("Friday");
//                break;
//            case 6: Console.WriteLine("Saturday");
//                break;  
//            case 7: Console.WriteLine("Sunday");
//                break;
//        };
//        break;
//        // якщо введені дані не є чмслом вертаємось до міткм введення даних
//    case false: Console.WriteLine("Это не номер а символы.\n\nПожалуйста введите номер от 1 до 7 !");
//        break;

//}