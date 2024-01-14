void SelectArr(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length-1; i++)
    {
    if(arr1[i].Length <= 3)
        {
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArr(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        // Console.Write(arr[i]);
        if (i != 0)
            Console.Write($", \"{arr[i]}\"");
            
        else
        {
            Console.Write($"\"{arr[i]}\"");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Введите количество элементов массива:\t");
int numElem = int.Parse(Console.ReadLine()!);
string[] arr1 = new string[numElem];
string[] arr2 = new string[arr1.Length];
for (int i = 0; i < arr1.Length; i++)
{
    Console.Write($"Введите элемент массива:\r\n  ", i+1);
    arr1[i] = Console.ReadLine()!;
}
SelectArr(arr1, arr2);
PrintArr(arr2);