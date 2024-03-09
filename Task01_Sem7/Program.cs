// Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от 1 до N.
// Указание
// Использовать рекурсию. Не использовать цикл.


void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}


Console.WriteLine("Enter the natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number);

