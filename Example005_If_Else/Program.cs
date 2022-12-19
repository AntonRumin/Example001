// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите имя пользователя: ");

string userName = Console.ReadLine();

if (userName.ToLower() == "антон")
{
    Console.WriteLine ("Привет, Брат!");
}
else
{
    Console.Write ("Привет, ");
    Console.WriteLine(userName);
}