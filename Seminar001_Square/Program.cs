// программа для определения квадрата числа: получает число и возвращает квадрат этого числа
/* Объявить переменные
Получить число с консоли
Преобразовать число
Возвести в квадрат
вернуть результат
*/
//Console.WriteLine("Hello, World!");

Console.Write("Введите целое число ");
string numberStr = Console.ReadLine() ?? "";
int number = int.Parse(numberStr);
int result = number*number;
Console.WriteLine($"Квадрат числа {number} равен {result}");
