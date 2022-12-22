// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();

Console.Write("Нахождение максимального из трех чисел");

Console.SetCursorPosition(10,2);

Console.Write ("введите Первое число, А = ");

double A = double.Parse(Console.ReadLine() ?? "0");

Console.SetCursorPosition(10,4);

Console.Write ("введите Второе число, В = ");

double B = double.Parse(Console.ReadLine() ?? "0");

Console.SetCursorPosition(10,6);

Console.Write ("введите Третье число, С = ");

double C = double.Parse(Console.ReadLine() ?? "0");

Console.SetCursorPosition(10,8);

double max = A;

if (B > max)
{
    max = B;
}
if (C > max)
{
    max = C;
}  
Console.Write ($"Максимальное число: {max}");

Console.SetCursorPosition(1,10);
Console.Write("* * *");