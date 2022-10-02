/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

/*
Console.Write("Введите число A: ");
int baseNum = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int powNum = int.Parse(Console.ReadLine());
Console.WriteLine($"{baseNum}, {powNum} -> {GetPow(baseNum,powNum)}");

int GetPow (int baseNum, int powNum)
{
    int result = 1;
    for (int i = 0; i < powNum; i++){
        result = result * baseNum;
    }
    return result;  
}
*/

/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

/*
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine($"{num} -> {GetSum(num)}");

int GetSum(int num){
    int sum = 0;
    while (num > 0){
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}
*/

/*
Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/*
int[] array = GetArray(8);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetArray(int size){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(100);
    }
    return result;
}
*/