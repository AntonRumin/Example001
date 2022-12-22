// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();

Console.Write("Определение четности целого числа");

Console.SetCursorPosition(10,2);

Console.Write ("Введите целое число, А = ");

int Num = int.Parse(Console.ReadLine() ?? "0");

int result = Num%2;

Console.SetCursorPosition(10,4);

if (Num%2 == 0)
{
    Console.Write ("Вы ввели четное число");
}
else

Console.Write ("Вы ввели нечетное число");

Console.SetCursorPosition(1,6);
Console.Write("* * *");
