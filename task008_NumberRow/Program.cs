// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Вывод четных чисел от 1 до N");

Console.SetCursorPosition(10,3);

Console.Write ("Введите целое число, N = ");

int Num = int.Parse(Console.ReadLine() ?? "0");

int count = 2;

Console.SetCursorPosition(10,6);

if (Num <= 1)
{
    Console.Write("Введенное число не соответствует условиям задачи");
}
else
{
    Console.Write ("Ряд четных чисел:  ");

while (count <= Num)
{
    Console.Write($"{count}, ");

    count = count + 2;
}
}

Console.SetCursorPosition(1,9);
Console.Write("* * *");