string[] InitArray(int countOfWords)
{
    string[] StringArray = new string[countOfWords];
    for(int i = 0; i < countOfWords; i ++)
    {
        StringArray[i] = Console.ReadLine();
    }
    return StringArray;
}

int CountOfShorts (string[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i].Length <= 3)
        {
            count ++;
        }
    }
}

string arrayOfShorts(string[] array, int count)
{
    
}