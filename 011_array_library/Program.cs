void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] collection)
{
    int count = collection.Length;
    int position = 0;
    
    while (position < count)
    {
        Console.WriteLine(collection[position]);
        position++;
    }
    Console.WriteLine();
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0, position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }

    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

int pos = IndexOf(array, 47);
Console.WriteLine(pos);
