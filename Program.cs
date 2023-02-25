string[] GetArray(string message) 
{
    string words = "";
    
    Console.WriteLine(message);
    words = Console.ReadLine();
    
    string[] wordsArray = words.Split(" ");

    return wordsArray;
}

string[] MakeSmallerArray(string[] array)
{
    string smallWords ="";

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            smallWords += $" {array[i]}";
        }
    }

    string[] newArray = smallWords.Split(" ");

    return newArray;
}

string[] wordsArray = GetArray("Для создания массива введите слова разделяя их знаком пробела.");
string[] smallWordsArray = MakeSmallerArray(wordsArray);

Console.WriteLine("Новый массив из строк состоящих не более чем из 3 символов:");
for (int i = 0; i < smallWordsArray.Length; i++)
{
    Console.Write($"{smallWordsArray[i]} ");
}