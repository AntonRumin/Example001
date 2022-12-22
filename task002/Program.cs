//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();

Console.WriteLine("Сравнение двух произвольных чисел");

Console.SetCursorPosition(10,2);

Console.Write ("введите Первое число, А = ");

int A = int.Parse(Console.ReadLine() ?? "0");

Console.SetCursorPosition(10,4);

Console.Write ("введите Второе число, B = ");

int B = int.Parse(Console.ReadLine() ?? "0");

Console.SetCursorPosition(10,6);

if (A < B)
{
    Console.Write ("Первое число меньше Второго числа ( А < В )");
}
else if (A > B)
{
    Console.Write ("Первое число больше Второго числа ( А > В )");
}

else

    Console.Write ("Первое число равно Второму числу ( А = В )");

Console.SetCursorPosition(1,8);
Console.Write("* * *");

