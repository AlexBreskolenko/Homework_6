/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4
*/
Console.Clear();

//Метод создания массива
int[] CreateArray(int size)
{
    return new int[size];
}
//Метод ввода
int EnterMessage(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine());
    return result;
}
//Метод заполненния массива
void FillArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        int enterNum = int.Parse(Console.ReadLine());
        arr[i] = enterNum;
    }
}
//Метод подсчета чисел больше 0
int CountNumber(int[] arr)
{
    int count = 0;

    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}
//Метод вывода массива
void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}


int size = EnterMessage("Сколько чисел вы хотите ввести ? :  ");
int[] array = CreateArray(size);
Console.WriteLine($"Введите {size} чисел(a) : ");
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Чисел больше нуля : {CountNumber(array)}.");
