// На основе символов строки (тип string) сформир    массив
// символов (тип char[]). Вывести массив на экран.

// Указание
// Метод строки ToCharArray() не использовать.

static char[] StringToCharArray(string str)
{
    char[] charsArray = new char[str.Length];

    for (int i = 0; i < charsArray.Length; i++)
    {
        charsArray[i] = str[i];
    }
    return charsArray;
}

void PrintArray(char[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.WriteLine("Enter the string");
string str = Console.ReadLine()!;

char[] chars = StringToCharArray(str);
PrintArray(chars);
