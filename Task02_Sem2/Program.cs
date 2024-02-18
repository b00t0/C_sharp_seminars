// Напишите программу, которая принимает на вход трёхзначное число и возводит вторую цифру этого числа в степень, равную третьей цифре.
// Примеры
// 487 => 8^7 = 2097152
// 254 => 5^4 = 625
// 617 => 1

Console.WriteLine("Введите целое трёхзначное число");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 100 && num <= 999 || num >= -999 && num <= -100)
{
    int secondDigit = num / 10 % 10; // 487 / 10 = 48.7  => 48 % 10 = 40 + 8
    int thirdDigit = num % 10; // 487 % 10 = 480 + 7

    if (thirdDigit < 0) {
        thirdDigit = thirdDigit * -1;
    }

    int result = 1;
    int count = 1;

    while (count <= thirdDigit)
    {
        result *= secondDigit;
        count ++;
    }

    Console.WriteLine($"{num} => {result}");
}
else
{
    Console.WriteLine("Некорректный ввод!");
}