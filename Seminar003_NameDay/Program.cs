//Программа для определения названия дня недели по номеру от 1 до 7"
Console.Clear();
Console.WriteLine("Определение названия дня недели");

Console.WriteLine ("Введите любое число от 1 до 7: ");
string stringNum = Console.ReadLine() ?? "0";


int numberNum = int.Parse(stringNum);

Console.SetCursorPosition(10,4);

if (numberNum == 0)
{
    Console.WriteLine("Вы не указали номер дня недели");
}
if (numberNum == 1)
{
    Console.Write("Понедельник");
}
if (numberNum == 2)
{
    Console.Write("Вторник");
}
if (numberNum == 3)
{
    Console.Write("Среда");
}
if (numberNum == 4)
{
    Console.Write("Четверг");
}
if (numberNum == 5)
{
    Console.Write("Пятница");
}
if (numberNum == 6)
{
    Console.Write("Суббота");
}
else if (numberNum == 7)
{
    Console.Write("Воскресенье");
}
else{
    Console.Write("Вы ввели число более 7");
}

