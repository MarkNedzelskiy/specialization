string[] GetArray(string message) 
{
    string words = "";
    
    Console.WriteLine(message);
    words = Console.ReadLine();
    
    string[] wordsArray = words.Split(" ");

    return wordsArray;
}