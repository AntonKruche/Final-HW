string[] InitArray(int countOfWords)
{
    string[] StringArray = new string[countOfWords];
    for(int i = 0; i < countOfWords; i ++)
    {
        Console.WriteLine("Введите слово:");
        StringArray[i] = Console.ReadLine();
    }
    return StringArray;
}

string[] RemoveLongWords (string[] array)
{
    int count = 0;
    foreach(string el in array)
    {
        if(el.Length <= 3)
        {
            count ++;
        }
    }
    int countOfel = 0;
    string[] resultArray = new string[count];
    foreach(string el in array)
    {
        if(el.Length <= 3)
        {
            resultArray[countOfel] = el;
            countOfel++;
        }
    }
    return resultArray;
}



Console.WriteLine("Введите количество строк в массиве: ");
int StringQuantity = int.Parse(Console.ReadLine());

string[] StringArray = RemoveLongWords(InitArray(StringQuantity));
Console.Write("['");
Console.Write("{0}" ,String.Join("', '", StringArray));
Console.Write("']");
