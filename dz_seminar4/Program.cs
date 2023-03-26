//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

System.Console.WriteLine("Введите число: ");
int aa = Convert.ToInt32(Console.ReadLine());
int Summ (int a)
{
    int a1 = 0;
    int summa=0;
    while (a!=0)
    {        
        a1 = a % 10;
        summa = summa + a1;
        a = a / 10;
    }
    return summa;
}

int summa = Summ(aa);
System.Console.WriteLine(summa);

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Write("Please, enter the length of the array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] Array(int size)
{
    int [] arr = new int [size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Please, enter the number under the index {i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}
int [] a = Array(size); 
void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write("]");
    System.Console.WriteLine();
}
PrintArray(a);

//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Please, enter your number a: ");
int num= Convert.ToInt32(Console.ReadLine());
Console.Write("Please, enter your number b: ");
int b = Convert.ToInt32(Console.ReadLine());
int st = 1;
for(int i = 1; i <= b; i++)
{
    st = st * num;
}
System.Console.WriteLine(st);

