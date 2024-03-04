// Считать строку с консоли, состоящую из латинских букв 
// в нижнем регистре. Выяснить, сколько среди введённых букв гласных.
// Пример
// “hello” => 2
// “world” => 1

// static char[] StringToCharArray(string str)
// {
//     char[] charsArray = new char[str.Length];

//     for (int i = 0; i < charsArray.Length; i++)
//     {
//         charsArray[i] = str[i];
//     }
//     return charsArray;
// }

// void PrintArray(char[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }


static int GetCountVowels(string str)
{
    int count = 0;
    string vowels = "aeiouy";

    for (int i = 0; i < str.Length; i++)
    {
        char currentChar = str[i];
        for (int j = 0; j < vowels.Length; j++)
        {
            if (vowels[j] == currentChar)
            {
                count++;
            }
        }
    }
    return count;
}


Console.WriteLine("Enter the string");
string str = Console.ReadLine()!;

Console.WriteLine(GetCountVowels(str));
