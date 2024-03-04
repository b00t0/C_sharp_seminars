// Задайте массив символов (тип char []). Создайте строку из 
// символов этого массива.
// Конструктор строки вида string(char []) не использовать.



string GetStringFromCharArray(char[] chars)
{
    string str = string.Empty;

    for (int i = 0; i < chars.Length; i++)
    {
        str += chars[i];
    }
    return str;
}

char[] charsArray = { 'a', 'b', 'c', 'd' };

Console.WriteLine(GetStringFromCharArray(charsArray));

