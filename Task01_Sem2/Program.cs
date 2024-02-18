// Напишите программу, которая принимает на вход трёхзначное число и удаляет вторую цифру этого числа.
// Примеры
// a = 256=> 26
// a = 891=> 81

Console.WriteLine("Введите целое трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

// int numCheck = num;
// if(num < 0) numCheck = -num;

if(num >= 100 && num <= 999 || num >= -999 && num <= -100)
{
    int firstDigit = num / 100; // 256 / 100 = 2.56 => 2
    int lastDigit = num % 10; // 256 % 10 = 250 + 6

    int result = firstDigit * 10 + lastDigit;
    Console.WriteLine($"{num} => {result}");
}
else
{
    Console.WriteLine("Некорректный ввод!");
}