// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое целое неотрицательное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое неотрицательное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Ackermann(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;
    else if (num1 > 0 && num2 == 0) return Ackermann(num1 - 1, 1);
    else return Ackermann(num1 - 1, Ackermann(num1, num2 - 1));
}

int res = 0;
if (number1 < 0 || number2 < 0) Console.WriteLine("Вы ввели отрицательные числа!");
else
{
    res = Ackermann(number1, number2);
    Console.WriteLine(res);
}