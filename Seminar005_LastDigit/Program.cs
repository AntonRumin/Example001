// Программ получает на вход трехзначное число и выдает последнюю цифру этого
Console.Clear();

Console.WriteLine("Вывод последней цифры трехзначного числа");

Console.SetCursorPosition(10,4);

Console.Write ("Введите любое целое трехзначное число, N = ");

int Num = int.Parse(Console.ReadLine() ?? "0");


if (Num > 99 && Num < 1000)
{
    Console.SetCursorPosition(10,6);

    Console.Write(Num % 10);
}

else

Console.Write("Ваше число не является трехзначным числом");