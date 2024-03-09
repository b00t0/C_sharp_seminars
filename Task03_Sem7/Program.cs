// Считать строку с консоли, содержащую латинские буквы. 
// Вывести на экран согласные буквы этой строки.
// Указание
// Использовать рекурсию. Не использовать цикл.


void ShowConsonants(string str)
{
    string vowels = "aeiouy";
    if (str.Length == 0) return;
    if (!vowels.Contains(str[0]))
    {
        Console.Write($"{str[0]} ");
    }
    ShowConsonants(str.Substring(1));
}


Console.WriteLine("Enter the text: ");
string str = Console.ReadLine();

ShowConsonants(str);
