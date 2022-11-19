// Задача 66: Задайте значения M и N.
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int NaturalNumbers(int num1, int num2)
{
    if(num2 < num1) return 0;
    return num2 + NaturalNumbers(num1, num2 - 1);
}

int res = 0;
if(number1 < number2) res = NaturalNumbers(number1, number2);
else res = NaturalNumbers(number2, number1);
Console.WriteLine();
Console.WriteLine(res);
