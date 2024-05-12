void PrintWordsArray(string[] array)
{
    foreach (string elem in array)
    {
        Console.Write(elem + " ");
    }
}

string[] CheckWordLenthInArray(string[] array)
{
    string[] result = new string[0];
    int index = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            Array.Resize(ref result, result.Length + 1);
            result[index] = item;
            index++;
        }
    }
    return result;
}

Console.WriteLine("Необходимо создать массив со словами.");
Console.Write("Сколько слов вы хотите добавить?: ");

int wordsAmount = Convert.ToInt32(Console.ReadLine());
string[] wordsArray = new string[wordsAmount];
Console.WriteLine("Введите слова по одному.");

for (int i = 0; i < wordsAmount; i++)
{
    Console.Write($"Enter word {i + 1}: ");
    wordsArray[i] = Console.ReadLine();
}


string[] resultArray = CheckWordLenthInArray(wordsArray);

PrintWordsArray(resultArray);