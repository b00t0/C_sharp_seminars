// Напишите программу, которая будет принимать на вход число и 
// возвращать сумму его цифр.
// Указание
// Использовать рекурсию.

int SumNumbers(int number)
{
	if(number == 0) return 0;
	return number % 10 + SumNumbers(number / 10);
}

Console.WriteLine(SumNumbers(123));

