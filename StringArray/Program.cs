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
    int countOfel = 0;
    string[] finalArray = new string[count];
    foreach(string el in array)
    {
        if (el.Length <=3)
        {
            finalArray[countOfel] = el;
            countOfel ++;
        }
    }
    return finalArray;
}


Console.WriteLine("Введите количество строк в массиве: ");
int StringQuantity = int.Parse(Console.ReadLine());

string[] array = InitArray(StringQuantity);
int ShortStringQuantity = CountOfShorts(array);
string[] resultArray = arrayOfShorts(array);

Console.WriteLine("{0}", String.Join(" ", array));
