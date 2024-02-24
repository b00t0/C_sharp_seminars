﻿// Дано натуральное трёхзначное число. Создайте массив, состоящий из цифр этого числа. Младший разряд 
// числа должен располагаться на 0- м индексе массива, старший – на 2-м.
// Пример
// 456 => [6 5 4]
// 781 => [1 8 7]

Console.WriteLine("Enter the integer natural three-digit number");
int num = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];

int i = 0;

if (num < 0)
{
    Console.WriteLine("Incorrect input");
    return;
}

if (num > 999 || num < 100)
{
    Console.WriteLine("Incorrect input");
    return;
}

while (num > 0)
{
    array[i] = num % 10;
    i = i + 1;
    num = num / 10;
}

for (int j = 0; j < array.Length; j++)
{
    Console.Write($"{array[j]} ");
}
