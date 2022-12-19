// пример 3 лекции 3_1. Сложение двух чисел
int numberOne = 86;
int numberTwo = 96;
int result = numberOne + numberTwo;
int randomResult = new Random().Next (1, numberOne) + new Random().Next (1,numberTwo);

Console.WriteLine(result);
Console.WriteLine(randomResult);
