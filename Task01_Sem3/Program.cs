// Задайте массив.Напишите программу, которая определяет,
// присутствует ли заданное число в массиве.
// Программа должна выдать ответ: Да/Нет.
// Примеры
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да

// int[] array1 = new int[8];
// int[] array2 = new int[8] { 4, 5, 6, 7, 4, 4, 56, 6 };
// int[] array3 = new int[] { 4, 5, 6, 7, 4, 4, 56, 6 };

Console.WriteLine("Enter the integer number");
int targetNum = Convert.ToInt32(Console.ReadLine());
int[] array = { 4, 5, 6, 4, 7, 8, 3, 46, 5 };
bool res = false;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] == targetNum)
    {
        res = true;
        break;
    }
}

// string result = res ? "Yes" : "No";
// Console.WriteLine(result);
Console.WriteLine(res ? "Yes" : "No");
