//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int Prompt(string message)
{
    Console.Write(message);
    int num = int.Parse(Console.ReadLine());
    return num;
}
int num = Prompt("Введите число от 1 до 9999 => ");

if (num > 99)
{
    if (num> 99 && num < 1000) System.Console.WriteLine($"В числе {num} третьей цифрой является число {num % 10}");
    
    if (num > 1000 && num < 10000) System.Console.WriteLine($"В числе {num} третьей цифрой является число {num / 10 % 10}");
}
else
    System.Console.WriteLine("В заданном числе нет третьей цифры или число больше заданного диапазона");
