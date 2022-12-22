// Программа: принимает два числа и определяет не явлляется ли одно из них квдратом второго.
// Объявить переменные, ввести числа, сравнить числа, вывести результат

Console.Clear();
Console.Write ("Введите первое число  ");
string stringOne = Console.ReadLine() ?? "";

Console.Write ("Введите второе число  ");
string stringTwo = Console.ReadLine() ?? "";

double numberOne = double.Parse(stringOne), 
       numberTwo = double.Parse(stringTwo);

if (numberOne == numberTwo*numberTwo)
{
    Console.WriteLine($"Число {numberOne} является квадратом числа {numberTwo}");
}
if (numberTwo == numberOne*numberOne)
{
    Console.WriteLine($"Число {numberTwo} является квадратом числа {numberOne}");
}
if (numberOne != numberTwo*numberTwo && numberTwo != numberOne*numberOne)
{
    Console.WriteLine("Числа не являются квадратами друг друга");
}