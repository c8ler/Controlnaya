Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int size = int.Parse(Console.ReadLine());  // ввод кол-ва элементов будущего массива

string[] array = new string[size];

for (int i = 0; i < size; i++)  // поочерёдный ввод элементов массива
{
    Console.Write($"Введите {i}-й элемент массива: ");
    array[i] = Convert.ToString(Console.ReadLine());
}

int newN = 0;
for (int k = 0; k < size; k++)  // определение кол-ва элементов массива, меньших 4 символов
{
    if (array[k].Length < 4) newN++;
}

if (newN == 0)
{
    Console.WriteLine();
    Console.WriteLine("->");
    Console.WriteLine("[]");
}
else
{
    // заполнение элементов нового массива
    string[] newArray = array.Where(x => x.Length <= 3).ToArray();

    print2Arr(array, size, newArray, newN);
}


void printArr (string[] arr, int sizeArr)
{
    Console.Write("[");
    for (int j = 0; j < sizeArr - 1; j++)
    {
        Console.Write($"\"{arr[j]}\" ");
    }
    Console.Write($"\"{arr[sizeArr - 1]}\"]");
}

void print2Arr (string[] arr1, int sizeArr1, string[] arr2, int sizeArr2)
{
    printArr(arr1, sizeArr1);
    Console.WriteLine();
    Console.WriteLine("->");
    printArr(arr2, sizeArr2);
}