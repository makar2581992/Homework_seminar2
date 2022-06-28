//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int Prompt(string message)
{
    Console.Write(message);
    int a = int.Parse(Console.ReadLine());
    return a;
}

int day = Prompt("Введите число, обозначающее день недели: =>");

if (day < 8)
{
    if (day > 0 && day < 6)
        System.Console.WriteLine("Это рабочий день");
    if (day > 5 && day < 8)
        System.Console.WriteLine("Это выходной день");
}
else
{
    System.Console.WriteLine("Введено некорректное число");
}
