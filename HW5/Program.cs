Main();

void Main()
{
    bool isWorking = true;
    while(isWorking){
        Console.WriteLine("Input task");
        string task = Console.ReadLine();

        switch(task){
            case "exit": isWorking = false; break;
            case "t34": Task34(); break;
            case "t36": Task36(); break;
            case "t38": Task38(); break;
            default: break;
        }
    }
}

int ReadInt(string argument)
{
    int number;
    Console.Write($"Введите {argument}:");
    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a number!");
    }
    return number;
}
//заполняем массив случайными числами
int[] CreateArray(int Length, int min, int max)
{
    int[] array = new int [Length];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min,max + 1);
    }
    return array;
}
//вывод массива на экран
void PrintArray(int [] numbers)
{
    System.Console.Write("[");
    for (int i = 0; i < numbers.Length -1; i++)
    {
        System.Console.Write(numbers[i] + "; ");
    }
    System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}

// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество 
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
void Task34(){
    int number = ReadInt("длину массива");
    int[] array = CreateArray(number, 100, 999);
    PrintArray(array);
    Console.WriteLine($"Количество четных чисел в массиве = {CountEvent(array)}");
}
// считаем количество четных чисел в массиве
int CountEvent(int [] array){
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0 ){
            count ++;
        }
    }
    return count;
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
void Task36(){
    int number = ReadInt("длину массива");
    int min = ReadInt("минимальное значение массива");
    int max = ReadInt("максимальное значение массива");
    int[] array = CreateArray(number, min, max);
    PrintArray(array);
    Console.WriteLine($"Сумма чисел с нечетным индексом = {SumValueOddIndex(array)}");
}
//нахождение суммы на нечетных позициях
int SumValueOddIndex(int [] array){
    int sumValue = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sumValue += array[i];
    }
    return sumValue;
}

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
void Task38(){
    int number = ReadInt("введите длину массива");
    int min = ReadInt("минимальное значение массива");
    int max = ReadInt("максимальное значение массива");
    double[] array = CreateDoubleArray(number, min, max);
    Console.WriteLine($"Разница между Max и Min массива = {MaxMinDiff(array)}");
}
//заполняем массив случайными веществ числами
double[] CreateDoubleArray(int length, int min, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
            array[i] = Math.Round(new Random().NextDouble() * (max - min) + min, 2); 
    }
    
    //вывод массива на экран
    System.Console.Write("[");
    for (int i = 0; i < array.Length -1; i++)
    {
        System.Console.Write(array[i] + "; ");
    }
    System.Console.WriteLine(array[array.Length -1] + "]");

    return array;
}
//нахождение мин и мах значения в массиве и их разность
double MaxMinDiff (double [] array){
    double minValue = array[0];
    double maxValue = array[0];
    double diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minValue) minValue = array[i];

        if (array[i] > maxValue) maxValue = array[i];
    }
    //Console.WriteLine("Максимум массива " + maxValue);
    //Console.WriteLine("Минимум массива " + minValue);
    diff = maxValue - minValue;
    return diff;
}