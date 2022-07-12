
Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = FillArray(size);
int newSize = FindNewSize(array, size);
if (newSize == 0)
{
    PrintArr(array, size);
    Print0SizeArray();
}
else
{
    Print2Arr(array, size, FillNewArray(array), newSize);
}


string[] FillArray(int size1)
{
    string[] arr1 = new string[size1];
    for (int i = 0; i < size1; i++)  // поочерёдный ввод элементов массива
    {
        Console.Write($"Введите {i}-й элемент массива: ");
        arr1[i] = Convert.ToString(Console.ReadLine());
    }
    return arr1;
}

int FindNewSize(string[] arr1, int size1)
{
    int nSize = 0;
    for (int k = 0; k < size1; k++)  // определение кол-ва элементов массива, меньших 4 символов
    {
        if (arr1[k].Length < 4) nSize++;
    }
    return nSize;
}

void Print0SizeArray()
{
    Console.Write(" -> []");
}

string[] FillNewArray(string[] arr1)
{
    string[] arr2 = arr1.Where(x => x.Length <= 3).ToArray();
    return arr2;
}

void PrintArr(string[] arr, int sizeArr)
{
    Console.Write("[");
    for (int j = 0; j < sizeArr - 1; j++)
    {
        Console.Write($"\"{arr[j]}\" ");
    }
    Console.Write($"\"{arr[sizeArr - 1]}\"]");
}

void Print2Arr(string[] arr1, int sizeArr1, string[] arr2, int sizeArr2)
{
    PrintArr(arr1, sizeArr1);
    Console.Write(" -> ");
    PrintArr(arr2, sizeArr2);
}