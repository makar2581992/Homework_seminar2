//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
int Rnd(int min, int max)                      
{
	Random rnd = new Random();
	return rnd.Next(min, max + 1);
}
int x = Rnd (100, 1000);
int y = 0;

int number()
{
	y = x / 100 * 10 + x % 10;
	return y;
}
number();
System.Console.WriteLine($"Если убрать вторую цифру из числа {x}, то получим число {y}");
