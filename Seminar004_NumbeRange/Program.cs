//Программа для определения всех чисел от 1 до ввведенного числа"
Console.Clear();
Console.WriteLine("Вывод чисел от 1 до N");

Console.Write ("Введите любое целое число, N = ");

int Num = int.Parse(Console.ReadLine() ?? "0");

int count = 0;

while (count < Num)
{
count = count + 1;

Console.Write($"{count}, ");
}

