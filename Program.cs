﻿// "Написать программу, 
// которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] arr1 = new string[5] {"привет", "32", "Who i am?", "Dog", "2+1=4"};
string[] arr2 = new string[arr1.Length];

void SelectArr(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
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
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}
SelectArr(arr1, arr2);
PrintArr(arr2);